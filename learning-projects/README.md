# Learning Projects

This directory contains educational projects designed to teach specific programming concepts, frameworks, or technologies. Each project includes detailed documentation and step-by-step tutorials.

## Purpose

Learning projects help developers:
- Understand fundamental concepts
- Learn new technologies and frameworks
- Practice coding techniques through hands-on examples
- Follow structured tutorials with clear outcomes

## Project Guidelines

Each learning project should:
- Focus on a specific concept or technology
- Include comprehensive documentation
- Provide step-by-step instructions
- Contain clear learning objectives
- Include code comments explaining key concepts
- Offer exercises or challenges for practice

## Adding Projects

Projects are added as Git submodules. To add a new learning project:

```bash
git submodule add <repository-url> learning-projects/<project-name>
```

See [CONTRIBUTING.md](../CONTRIBUTING.md) for detailed guidelines.

## Current Projects

Projects will be added here as Git submodules. Each project will have its own repository with complete documentation and source code.

### Example Structure

```
learning-projects/
├── csharp-basics/          # Introduction to C# fundamentals
├── design-patterns/        # Gang of Four design patterns in C#
├── async-programming/      # Async/await and Task-based programming
├── entity-framework/       # EF Core fundamentals
└── aspnet-core-mvc/       # ASP.NET Core MVC tutorial
```

## How to Use

1. Clone the portfolio repository with submodules:
   ```bash
   git clone --recursive https://github.com/roughcutsoftware/portfolio.git
   ```

2. Navigate to a learning project:
   ```bash
   cd learning-projects/<project-name>
   ```

3. Follow the project's README.md for specific instructions

4. Open the .sln file in Visual Studio to start learning!

## Suggested Learning Path

For beginners, we recommend starting with:
1. C# Basics
2. Object-Oriented Programming concepts
3. Design Patterns
4. Framework-specific projects (ASP.NET, Entity Framework, etc.)

## Contributing

Have an idea for a learning project? See [CONTRIBUTING.md](../CONTRIBUTING.md) to learn how to contribute!
