# 流畅终端中文版

流畅终端是一个基于UMP和web技术的终端模拟器。

## 特性

- 可以使用CMD、PowerShell、WSL或自定义终端程序
- 支持标签页及多窗口
- 支持自定义主题与外观
- 导入或导出主题
- 导入iTerm主题
- 支持全屏
- 可自定义快捷键
- 支持搜索
- 通过编辑配置在不同shell间快速切换
- 资源管理器右键目录 ([点此链接下载安装脚本](https://github.com/mahoshojoHCG/FluentTerminal/tree/master/Explorer%20Context%20Menu%20Integration))
- 我能看到的地方都汉化了（中文版新增）

## 截图（原版截图）

![终端窗口](Screenshots/terminal.jpg)
![设置窗口](Screenshots/settings.jpg)

## 以后新增的功能

- 使用特定的快捷键启动新的终端配置
- 复制和粘贴选项
- 改进标签页
- 多屏幕支持

## 作为用户，该如何安装

### 系统需求
- Windows 10创造者更新（16299）或更新的系统。

### 自动安装

- 下载最新的安装文件 [下载](https://github.com/mahoshojoHCG/FluentTerminal/releases)。
- 右键 `Install.ps1`，选择"使用PowerShell运行"。
- 安装脚本会知道你完成安装。

### 手动安装

- 下载最新的安装文件 [下载](https://github.com/mahoshojoHCG/FluentTerminal/releases)。
- [启用旁加载模式](https://www.windowscentral.com/how-enable-windows-10-sideload-apps-outside-store)
  - 额外地，如果你想进行UMP应用开发，[启用开发者模式](https://docs.microsoft.com/zh-CN/windows/uwp/get-started/enable-your-device-for-development) **对于绝大多数用户来书，这是没必要的。**
- 将所有的*.cer证书文件安装到`本地计算机` -> `受信任的根证书颁发机构`
  - 这需要管理员权限。如果没有要求管理员权限，你很可能选错了安装位置。

![右键然后选择安装证书](Screenshots/right-click_install-certificate.png)

![将证书安装到本地计算机](Screenshots/install-certificate_local-machine.png)

- 双击*.appxbundle文件
- **可选** 添加到到资源管理器的右键菜单([点此链接下载安装脚本](https://github.com/mahoshojoHCG/FluentTerminal/tree/master/Explorer%20Context%20Menu%20Integration)

## 如何搭建开发环境
[点此查看](https://github.com/mahoshojoHCG/FluentTerminal/wiki/How-to-set-up-a-development-environment)
