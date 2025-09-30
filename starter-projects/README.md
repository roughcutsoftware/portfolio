# Starter Projects

This directory contains ready-to-use project templates that provide a solid foundation for starting new applications. These templates include common configurations, folder structures, and basic implementations.

## Purpose

Starter projects help developers:
- Bootstrap new applications quickly
- Follow best practices from the start
- Use pre-configured tooling and dependencies
- Learn recommended project structures
- Save time on initial setup

## Project Guidelines

Each starter project should:
- Be production-ready (or near production-ready)
- Include essential configurations and dependencies
- Follow industry best practices
- Contain clear setup instructions
- Be well-documented
- Include examples of common use cases
- Have a solid folder structure

## Adding Projects

Projects are added as Git submodules. To add a new starter project:

```bash
git submodule add <repository-url> starter-projects/<project-name>
```

See [CONTRIBUTING.md](../CONTRIBUTING.md) for detailed guidelines.

## Current Projects

Projects will be added here as Git submodules. Each project will have its own repository with complete documentation and source code.

### Example Structure

```
starter-projects/
├── aspnet-core-api/           # RESTful API template with auth
├── blazor-wasm-app/           # Blazor WebAssembly SPA template
├── wpf-mvvm-app/              # WPF desktop app with MVVM
├── console-app-template/      # Console app with DI and logging
├── microservice-template/     # Microservice with common patterns
└── azure-functions-starter/   # Azure Functions starter kit
```

## Features to Expect

Most starter projects include:
- ✅ Dependency Injection setup
- ✅ Configuration management
- ✅ Logging infrastructure
- ✅ Error handling
- ✅ Testing framework setup
- ✅ CI/CD pipeline examples
- ✅ Docker configuration (where applicable)
- ✅ API documentation (for APIs)

## How to Use

1. Clone the portfolio repository with submodules:
   ```bash
   git clone --recursive https://github.com/roughcutsoftware/portfolio.git
   ```

2. Navigate to a starter project:
   ```bash
   cd starter-projects/<project-name>
   ```

3. Copy the project to your workspace:
   ```bash
   cp -r starter-projects/<project-name> ~/my-workspace/my-new-project
   cd ~/my-workspace/my-new-project
   ```

4. Initialize a new Git repository:
   ```bash
   rm -rf .git
   git init
   git add .
   git commit -m "Initial commit from starter template"
   ```

5. Customize and start building!

## Customization Tips

After copying a starter project:
- Update project/solution names
- Modify namespaces
- Update configuration files
- Remove unnecessary features
- Add project-specific dependencies
- Update README.md with your project details

## Contributing

Have a great starter template? See [CONTRIBUTING.md](../CONTRIBUTING.md) to learn how to contribute!
