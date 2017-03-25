## Ark Controller
Ark Controller是基于adb封装的Android控制器，运行在Windows系统之上。详情查看[GitHub Page](https://maisonwan.github.io/ArkController/) 


### 连接设备
等待设备连接，获取可以连接设备列表

```connect
等待设备连接
adb wait-for-device devices
```

### 设备信息
设备信息包括，设备编码、名称、日期、分辨率、当前应用、输入法和屏幕截图。
```device info
屏幕截图
adb shell screencap -p <device_path>     -device_path设备路径

拉取文件
adb pull <device_path> <local>   -device_path设备路径, local本地路径

电池信息
adb shell dumpsys battery

设备日期
adb shell date

当前应用
adb shell dumpsys activity | grep "mFocusedActivity"

系统输入法
adb shell ime list -s

获取屏幕像素密度
adb shell wm density

获取屏幕分辨率
adb shell wm size

设置屏幕像素密度
adb shell wm density <density>     -density像素密度

设置屏幕分辨率
adb shell wm size <width>x<height>    -width，height屏幕宽高

重置屏幕分辨率
adb shell wm size reset

```

### 按键控制
模拟系统按键，常用返回、主页、电源，重启，声音按键，以及字母和数字按键的模拟。
```key
模拟按键输入
adb shell input keyevent <keycode>     -keycode按键的编码

模拟输入文本
adb shell input text <"text">     -text即为要输入的文本

```

### 应用列表
获取设备上安装的应用列表，按照类型过滤，应用包名过滤。
```program list
获取应用列表
adb shell pm list package [-f] [-i] [-s] [-3]    -f安装位置，-i程序类型，-s系统程序，-3第三方程序

打开应用详细信息
adb shell am start -a android.settings.APPLICATION_DETAILS_SETTINGS -d package:<package>

清空应用数据
adb shell pm clear <package>

获取应用信息
adb shell dumpsys package <package>

获取设备详细信息
adb shell pm dump <package>

杀掉当前应用进程
adb shell am force-stop <package>

隐藏应用
adb shell pm hide <package>

恢复应用
adb shell pm unhide <package>
```

### 进程列表
查看进程列表，进程类型，杀掉进程
```ps
获取进程
adb shell ps
```

### Logcat
控制输出logcat的日志和过滤
```logcat
过滤logcat输出
adb logcat -v time *:[level] -level包含 V，D，I，W，E，F，S，分别代表不同级别的log
```

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://help.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.
