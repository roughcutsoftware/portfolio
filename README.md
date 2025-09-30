# Portfolio - Learning & How-To Projects Repository

Welcome to the portfolio repository! This is a curated collection of 'learning' and 'how-to' Visual Studio IDE projects designed to demonstrate various programming concepts, techniques, and best practices.

> 📚 **[Documentation Index](DOCUMENTATION_INDEX.md)** - Complete guide to all documentation in this repository

## Repository Structure

This repository is organized to house multiple projects while demonstrating advanced Git concepts, particularly Git submodules for managing independent project repositories within a top-level portfolio.

```
portfolio/
├── README.md                 # This file
├── GIT_GUIDE.md             # Advanced Git concepts and command examples
├── CONTRIBUTING.md          # Guidelines for adding new projects
├── .gitmodules              # Git submodules configuration
├── learning-projects/       # Educational and tutorial projects
├── starter-projects/        # Ready-to-use starter templates
└── conceptual-projects/     # Projects demonstrating specific concepts
```

## Project Categories

### 1. Learning Projects (`learning-projects/`)
Educational projects designed to teach specific programming concepts, frameworks, or technologies. These projects include detailed documentation and step-by-step tutorials.

### 2. Starter Projects (`starter-projects/`)
Ready-to-use project templates that provide a solid foundation for starting new applications. These include common configurations, folder structures, and basic implementations.

### 3. Conceptual Projects (`conceptual-projects/`)
Projects that demonstrate specific programming concepts, design patterns, algorithms, or architectural approaches.

## Working with Git Submodules

This repository uses Git submodules to manage multiple independent projects. Each project can be maintained in its own repository while being accessible from this portfolio.

### Quick Start with Submodules

```bash
# Clone this repository with all submodules
git clone --recursive https://github.com/roughcutsoftware/portfolio.git

# If you already cloned without --recursive, initialize submodules
git submodule init
git submodule update

# Update all submodules to their latest commits
git submodule update --remote --merge
```

For more advanced Git concepts and commands, see [GIT_GUIDE.md](GIT_GUIDE.md).

## Getting Started

1. **Clone the repository:**
   ```bash
   git clone --recursive https://github.com/roughcutsoftware/portfolio.git
   cd portfolio
   ```

2. **Explore projects:**
   Each project directory contains its own README with specific instructions.

3. **Open in Visual Studio:**
   Navigate to any project directory and open the `.sln` file in Visual Studio IDE.

## Contributing

We welcome contributions! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines on adding new projects or improving existing ones.

## Requirements

- Visual Studio 2019 or later (or Visual Studio Code for cross-platform projects)
- Git 2.13 or later (for submodule improvements)
- .NET SDK (version specified in individual projects)

## License

This repository is licensed under CC0 1.0 Universal. See [LICENSE](LICENSE) for details.

## Resources

- [Visual Studio Setup Guide](VISUAL_STUDIO_SETUP.md) - IDE setup and configuration
- [Advanced Git Guide](GIT_GUIDE.md) - Git concepts and submodule usage
- [Quick Reference](QUICK_REFERENCE.md) - Common Git commands
- [Git Submodules Documentation](https://git-scm.com/book/en/v2/Git-Tools-Submodules)
- [Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/)