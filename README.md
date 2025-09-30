# portfolio

A portfolio project built with .NET.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or later (Community, Professional, or Enterprise edition)
- .NET 9.0 SDK or later (included with Visual Studio)

Alternatively, you can use:
- [Visual Studio Code](https://code.visualstudio.com/) with the C# extension
- [JetBrains Rider](https://www.jetbrains.com/rider/)

## Getting Started

### Clone the Repository

1. Open a terminal or command prompt
2. Navigate to your desired workspace directory
3. Clone the repository:
   ```bash
   git clone https://github.com/roughcutsoftware/portfolio.git
   cd portfolio
   ```

### Opening in Visual Studio

1. Launch Visual Studio
2. Select **File > Open > Project/Solution**
3. Navigate to the cloned repository folder
4. Select `Portfolio.sln` and click **Open**

Alternatively, you can double-click the `Portfolio.sln` file in Windows Explorer.

### Building the Project

In Visual Studio:
- Press `Ctrl+Shift+B` or select **Build > Build Solution** from the menu

From the command line:
```bash
dotnet build
```

### Running the Project

In Visual Studio:
- Press `F5` to run with debugging, or `Ctrl+F5` to run without debugging

From the command line:
```bash
dotnet run --project src/Portfolio/Portfolio.csproj
```

## Project Structure

```
portfolio/
├── Portfolio.sln           # Visual Studio solution file
├── src/
│   └── Portfolio/
│       ├── Portfolio.csproj    # Project file
│       └── Program.cs          # Main entry point
├── README.md
├── LICENSE
└── .gitignore
```

## License

This project is licensed under CC0 1.0 Universal - see the [LICENSE](LICENSE) file for details.