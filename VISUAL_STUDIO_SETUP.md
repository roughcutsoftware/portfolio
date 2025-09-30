# Visual Studio Setup Guide

This guide provides recommendations for setting up Visual Studio to work effectively with projects in this portfolio.

## Recommended Visual Studio Version

- **Visual Studio 2022** (Latest version recommended)
- **Visual Studio 2019** (Minimum version 16.0)
- **Visual Studio Code** (For cross-platform projects)

## Required Workloads

When installing Visual Studio, ensure these workloads are selected:

### Essential Workloads
- ✅ **.NET desktop development** - For WPF, WinForms, and console applications
- ✅ **ASP.NET and web development** - For web applications and APIs
- ✅ **Azure development** - For cloud-based projects
- ✅ **Data storage and processing** - For database projects

### Optional but Recommended
- **Universal Windows Platform development** - For UWP apps
- **Mobile development with .NET** - For Xamarin/MAUI projects
- **.NET Core cross-platform development** - For cross-platform applications

## Recommended Extensions

### Productivity Extensions
1. **Git Extensions for Visual Studio** - Enhanced Git integration
2. **GitHub Extension for Visual Studio** - Direct GitHub integration
3. **Visual Studio IntelliCode** - AI-assisted code completion
4. **CodeMaid** - Code cleanup and organization
5. **ReSharper** (Paid) - Advanced code analysis and refactoring

### Code Quality Extensions
1. **SonarLint** - Code quality and security analysis
2. **Visual Studio Spell Checker** - Catch typos in code and comments
3. **StyleCop Analyzers** - C# style and consistency checking
4. **Roslynator** - Code analysis and refactorings

### Debugging Extensions
1. **OzCode** (Paid) - Enhanced debugging experience
2. **Conveyor** - Test web apps on mobile devices
3. **Web Essentials** - Web development tools

## Git Configuration in Visual Studio

### Setup Git Integration
1. **Tools** → **Options** → **Source Control**
2. Select **Git** as the current source control plug-in
3. Configure user name and email:
   - **Tools** → **Options** → **Source Control** → **Git Global Settings**

### Configure External Git Tool
For advanced Git operations (like submodule management):
1. Install **Git for Windows** (https://git-scm.com/)
2. Add Git to PATH environment variable
3. In Visual Studio: **Tools** → **Options** → **Source Control** → **Git Repository Settings**

## Project Configuration

### .editorconfig
Projects should include an `.editorconfig` file for consistent code formatting:

```ini
root = true

[*]
charset = utf-8
indent_style = space
indent_size = 4
insert_final_newline = true
trim_trailing_whitespace = true

[*.cs]
# C# Code Style Rules
dotnet_sort_system_directives_first = true
csharp_new_line_before_open_brace = all
csharp_new_line_before_else = true
csharp_new_line_before_catch = true
csharp_new_line_before_finally = true

# Naming Conventions
dotnet_naming_rule.interfaces_should_be_prefixed_with_i.severity = warning
dotnet_naming_rule.interfaces_should_be_prefixed_with_i.symbols = interface
dotnet_naming_rule.interfaces_should_be_prefixed_with_i.style = begins_with_i

[*.{json,xml,config}]
indent_size = 2
```

### Solution/Project Organization
```
Solution/
├── src/                    # Source code projects
├── tests/                  # Test projects
├── docs/                   # Documentation
├── samples/                # Sample/example projects
└── tools/                  # Build scripts and tools
```

## Working with Submodules in Visual Studio

### Visual Studio Git Tools
Visual Studio has limited submodule support. For advanced operations, use:
- **Team Explorer** → **Changes** → **Command Prompt** to access Git CLI
- **Git Bash** or **PowerShell** for submodule commands

### Common Submodule Operations in VS

#### Cloning with Submodules
Use command line:
```bash
git clone --recursive https://github.com/roughcutsoftware/portfolio.git
```

Then open in Visual Studio.

#### Updating Submodules
1. Open **Team Explorer**
2. Click **Sync**
3. Run from command prompt:
   ```bash
   git submodule update --remote --merge
   ```

#### Working in a Submodule
1. Navigate to submodule directory
2. Open the submodule's `.sln` file separately
3. Make changes and commit
4. Return to parent solution
5. Commit submodule reference update

## Keyboard Shortcuts

### Essential Shortcuts
| Action | Shortcut |
|--------|----------|
| Build Solution | `Ctrl+Shift+B` |
| Run/Debug | `F5` |
| Run Without Debugging | `Ctrl+F5` |
| Stop Debugging | `Shift+F5` |
| Go to Definition | `F12` |
| Find References | `Shift+F12` |
| Quick Search | `Ctrl+Q` |
| Go to File | `Ctrl+1, F` |
| Solution Explorer | `Ctrl+Alt+L` |
| Git Changes | `Ctrl+0, Ctrl+G` |

### Code Navigation
| Action | Shortcut |
|--------|----------|
| Navigate Back | `Ctrl+-` |
| Navigate Forward | `Ctrl+Shift+-` |
| Go to Line | `Ctrl+G` |
| Find in Files | `Ctrl+Shift+F` |
| Replace in Files | `Ctrl+Shift+H` |

### Refactoring
| Action | Shortcut |
|--------|----------|
| Rename | `Ctrl+R, Ctrl+R` or `F2` |
| Extract Method | `Ctrl+R, Ctrl+M` |
| Extract Interface | `Ctrl+R, Ctrl+I` |
| Quick Actions | `Ctrl+.` |

## NuGet Package Management

### Managing Packages
1. **Tools** → **NuGet Package Manager** → **Manage NuGet Packages for Solution**
2. Use **Package Manager Console** for CLI operations:
   ```powershell
   Install-Package <PackageName>
   Update-Package <PackageName>
   Uninstall-Package <PackageName>
   ```

### Recommended Packages
- **xUnit** or **NUnit** - Unit testing frameworks
- **Moq** - Mocking framework
- **FluentAssertions** - Better assertion syntax
- **Serilog** - Structured logging
- **AutoMapper** - Object mapping
- **Newtonsoft.Json** - JSON serialization

## Performance Optimization

### Visual Studio Settings
1. **Tools** → **Options** → **Environment** → **Synchronize Settings** - Turn off if not needed
2. **Tools** → **Options** → **Text Editor** → **All Languages** → **CodeLens** - Disable if slow
3. **Tools** → **Options** → **IntelliSense** - Adjust completion settings
4. Close unused tool windows
5. Disable unused extensions

### Build Performance
1. Use **Build** → **Configuration Manager** to control what builds
2. Enable parallel builds: **Tools** → **Options** → **Projects and Solutions** → **Build and Run**
3. Consider using **dotnet CLI** for faster builds:
   ```bash
   dotnet build
   dotnet test
   ```

## Troubleshooting

### Common Issues

#### Git Submodule Not Loading
- Close Visual Studio
- Run `git submodule update --init --recursive` from command line
- Reopen solution

#### IntelliSense Not Working
- **Build** → **Clean Solution**
- Close Visual Studio
- Delete `.vs` folder in solution directory
- Reopen solution and rebuild

#### NuGet Package Restore Fails
- Clear NuGet cache: **Tools** → **NuGet Package Manager** → **Package Manager Settings** → **Clear All NuGet Cache(s)**
- Or use CLI: `dotnet nuget locals all --clear`

#### Build Fails with Submodules
- Ensure all submodules are initialized
- Check that submodule projects build independently
- Verify project references are correct

## Tips and Best Practices

1. **Use Git from Command Line for Submodules**: Visual Studio's Git integration has limited submodule support
2. **Keep Visual Studio Updated**: Regular updates include bug fixes and new features
3. **Use Solution Filters**: For large solutions, use `.slnf` files to load only needed projects
4. **Enable Git Credential Manager**: Store credentials securely
5. **Customize Layout**: Save custom window layouts for different tasks
6. **Use Code Snippets**: Create reusable code templates
7. **Learn Shortcuts**: Increases productivity significantly

## Resources

- [Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)
- [Visual Studio Keyboard Shortcuts](https://docs.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio)
- [Visual Studio Marketplace](https://marketplace.visualstudio.com/)
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
