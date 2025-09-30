# Contributing to Portfolio

Thank you for your interest in contributing to this portfolio repository! This document provides guidelines for adding new projects and improving existing ones.

## Table of Contents
- [Getting Started](#getting-started)
- [Adding a New Project](#adding-a-new-project)
- [Project Guidelines](#project-guidelines)
- [Contribution Workflow](#contribution-workflow)
- [Code Standards](#code-standards)

---

## Getting Started

1. **Fork the Repository**: Click the "Fork" button on GitHub
2. **Clone Your Fork**:
   ```bash
   git clone --recursive https://github.com/YOUR-USERNAME/portfolio.git
   cd portfolio
   ```
3. **Add Upstream Remote**:
   ```bash
   git remote add upstream https://github.com/roughcutsoftware/portfolio.git
   ```

---

## Adding a New Project

### Step 1: Determine Project Category

Choose the appropriate category for your project:
- **learning-projects/**: Educational tutorials and step-by-step guides
- **starter-projects/**: Ready-to-use templates and boilerplates
- **conceptual-projects/**: Demonstrations of specific concepts or patterns

### Step 2: Create the Project Repository

Each project should have its own Git repository with:
- Clear project name (use lowercase-with-hyphens)
- Comprehensive README.md
- Valid Visual Studio solution (.sln) file
- Appropriate .gitignore
- LICENSE file

### Step 3: Add as a Submodule

```bash
# Navigate to the portfolio repository
cd portfolio

# Add your project as a submodule
git submodule add <your-project-repository-url> <category>/<project-name>

# Example:
git submodule add https://github.com/username/aspnet-core-api-starter.git starter-projects/aspnet-core-api-starter

# Commit the changes
git add .gitmodules <category>/<project-name>
git commit -m "Add <project-name> to <category>"
git push
```

### Step 4: Update Portfolio Documentation

Update the main README.md to include:
- Brief description of your project
- Link to the project directory
- Any special requirements or prerequisites

---

## Project Guidelines

### Required Components

Each project must include:

1. **README.md** with:
   - Project title and description
   - Learning objectives or use case
   - Prerequisites and requirements
   - Setup and installation instructions
   - Usage examples
   - Key concepts covered
   - Additional resources

2. **Visual Studio Solution**:
   - Valid .sln file that opens in Visual Studio
   - Organized project structure
   - Build without errors on a clean machine

3. **Documentation**:
   - Code comments for complex logic
   - XML documentation for public APIs
   - Architecture decisions documented

4. **LICENSE**:
   - Clear licensing information
   - Compatible with portfolio's CC0 license

### Recommended Components

- **Examples/**: Sample implementations or use cases
- **Tests/**: Unit tests and integration tests
- **Docs/**: Additional documentation, diagrams, or tutorials
- **.editorconfig**: Code style configuration
- **CHANGELOG.md**: Version history

### Project Structure Example

```
project-name/
├── README.md
├── LICENSE
├── .gitignore
├── .editorconfig
├── ProjectName.sln
├── src/
│   └── ProjectName/
│       ├── ProjectName.csproj
│       ├── Program.cs
│       └── ...
├── tests/
│   └── ProjectName.Tests/
│       ├── ProjectName.Tests.csproj
│       └── ...
├── docs/
│   └── architecture.md
└── examples/
    └── SampleUsage/
```

---

## Contribution Workflow

### 1. Create a Feature Branch

```bash
git checkout -b add-project-name
```

### 2. Make Your Changes

- Add your project as a submodule
- Update documentation
- Test that everything works

### 3. Commit Your Changes

```bash
git add .
git commit -m "Add [project-name] to [category]

- Brief description of what the project does
- Key technologies used
- Learning objectives"
```

### 4. Push to Your Fork

```bash
git push origin add-project-name
```

### 5. Create a Pull Request

- Go to GitHub and create a Pull Request
- Provide a clear description of your changes
- Reference any related issues
- Wait for review and feedback

### 6. Update After Review

```bash
# Fetch and merge any upstream changes
git fetch upstream
git merge upstream/main

# Make requested changes
# ...

# Push updates
git push origin add-project-name
```

---

## Code Standards

### General Guidelines

- **Follow C# Coding Conventions**: Use Microsoft's C# coding conventions
- **Consistent Formatting**: Use 4 spaces for indentation (no tabs)
- **Meaningful Names**: Use descriptive variable and method names
- **Comments**: Comment complex logic, not obvious code
- **Error Handling**: Implement proper exception handling

### Visual Studio Configuration

Include an `.editorconfig` file in your project:

```ini
root = true

[*]
charset = utf-8
indent_style = space
indent_size = 4
insert_final_newline = true
trim_trailing_whitespace = true

[*.cs]
dotnet_sort_system_directives_first = true
dotnet_style_qualification_for_field = false:suggestion
dotnet_style_qualification_for_property = false:suggestion
csharp_new_line_before_open_brace = all
```

### Commit Message Guidelines

Follow the conventional commit format:

```
<type>: <subject>

<body>

<footer>
```

**Types**:
- `feat`: New feature or project
- `fix`: Bug fix
- `docs`: Documentation changes
- `style`: Code style changes (formatting)
- `refactor`: Code refactoring
- `test`: Adding or updating tests
- `chore`: Maintenance tasks

**Example**:
```
feat: Add ASP.NET Core API starter project

- Includes JWT authentication
- Swagger/OpenAPI documentation
- Entity Framework Core setup
- Repository pattern implementation

Closes #123
```

---

## Quality Checklist

Before submitting a pull request, ensure:

- [ ] Project builds without errors in Visual Studio
- [ ] All tests pass (if applicable)
- [ ] README.md is complete and accurate
- [ ] Code follows style guidelines
- [ ] No sensitive information (API keys, passwords) is committed
- [ ] .gitignore is properly configured
- [ ] LICENSE file is included
- [ ] Documentation is clear and helpful
- [ ] Project demonstrates the intended concept clearly

---

## Getting Help

- **Questions**: Open a discussion on GitHub Discussions
- **Bugs**: Open an issue with a detailed description
- **Feature Requests**: Open an issue with the "enhancement" label

---

## Code of Conduct

- Be respectful and inclusive
- Provide constructive feedback
- Focus on the code, not the person
- Help others learn and grow

---

## Recognition

Contributors will be recognized in:
- Project README.md
- GitHub contributors page
- Release notes (for significant contributions)

Thank you for contributing to the portfolio!
