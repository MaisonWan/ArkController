using System;
using System.Collections.Generic;
using System.Text;
using ArkController.Kit;

namespace ArkController.Data
{
    /// <summary>
    /// 设备管理器
    /// </summary>
    public class DeviceManager
    {
        private BatteryParser batterParser = null;
        private DeviceLink deviceLink = null;
        private Package package = null;
        private ScreenData screenData = null;

        public DeviceManager(IConnect connect)
        {
            deviceLink = new DeviceLink(connect);
            package = new Package(connect);
            screenData = new ScreenData(connect);
        }

        /// <summary>
        /// 连接设备
        /// </summary>
        public DeviceLink DeviceLink
        {
            get { return this.deviceLink; }
        }

        /// <summary>
        /// 解析电池信息
        /// </summary>
        public BatteryParser BatteryParser
        {
            get { return this.batterParser; }
            set { this.batterParser = value; }
        }

        /// <summary>
        /// 包信息
        /// </summary>
        public Package Package
        {
            get { return this.package; }
        }

        /// <summary>
        /// 屏幕数据，分辨率，像素密度
        /// </summary>
        public ScreenData ScreenData
        {
            get { return this.screenData; }
        }
    }
}
