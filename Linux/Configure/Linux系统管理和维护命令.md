##  chap2 系统管理与设置
+ 常用的信息显示命令
    + `cal` 日历
    + `cat /proc/meminfo`内存使用情况
    + `free`内存详细信息，*注意显示单位*
    + `arch`CPU架构，等同于`uname -m`
    + `cat /proc/cpuinfo` 处理器CPU信息
    + `cat /proc/modules` 被加载的模块
+ 系统信息显示命令
    + **proc文件系统**：访问系统的内核信息
    + `modinfo` 显示内核模块信息
    + `cat /ect/issue` 系统的发行版本
    + `dmesg` 检测和控制内核的缓存
+ 2.3 系统常用信息设置
+ 2.4 文件系统信息显示常用命令
    + `echo`
    + `isosize`
    + `minfo`    
+ Linux操作系统信息查询
    + `uname` 操作系统信息
    + `vmstat`  虚拟内存的统计信息
    + `uptime` 系统的运行时间
    + `locale` 当前系统的语言设置
    + `tload` 系统负载显示
    + `runlevel` 系统运行级别
    + `lsmod` 所有已加载模块的显示
+ 2.6 进程资源
    + `top`
    + `ipcs`
    + `time`
    + `pstree`
    + `ps`
    + `pmap`
    + `jobs`
    + `mev`
    + `fuser`
+ 2.7 Linux终端命令行操作
    + `fgconsole`
    + `history`
    + `gdialog`
    + `yes`

##  chap3 系统维护与管理
+ 3.1 常用的系统管理任务
    + `apm`
    + `apmsleep`
    + `open`
    + `vlock`
    + `sudo`
    + `rsh`
    + `chsh`
    + `clear`
    + `rlogin`
+ 3.2 进程任务管理
+ 3.3 设置系统的各种任务
    + `ntsysv`
    + `symlinks`
    + `mtools`
+ 3.4 后台任务管理
    + `bg`
    + `wait`
    + `depmod`
    + `rmmod`
    + `ipcrm`
    + `watch`
    + `fc`
    + `nohup`
    + `suspend`
    + `sleep`

##  chap4 系统维护命令
+ 4.1 常用的系统维护命令
    + `bind`
    + `enable`
    + `aumix`
    + `export`
    + `hostid`
    + `alias`
    + `chkconfig`
    + `eval`
    + `dircolors`
    + `set`
    + `telinit`
+ 4.2 系统的日常配置
+ 4.3 其它常用命令
+ 4.4 自动作业处理
+ 4.5 系统日志
    + `syslogd`
    + `syslog.conf`
    + `logger`
    + echo清空日志