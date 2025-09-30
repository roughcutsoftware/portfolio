# Workflow Examples

This document provides practical workflow examples for common scenarios when working with this portfolio repository.

## Table of Contents
- [Adding a New Learning Project](#adding-a-new-learning-project)
- [Updating an Existing Submodule Project](#updating-an-existing-submodule-project)
- [Creating a New Starter Template](#creating-a-new-starter-template)
- [Collaborating on a Project](#collaborating-on-a-project)
- [Syncing Your Fork](#syncing-your-fork)

---

## Adding a New Learning Project

### Scenario
You've created a new C# tutorial project and want to add it to the portfolio.

### Prerequisites
- Your project is in its own Git repository
- The project includes a comprehensive README
- The project builds without errors in Visual Studio

### Steps

1. **Ensure your project repository is ready**
   ```bash
   cd ~/my-projects/csharp-async-tutorial
   git status  # Ensure everything is committed
   git push    # Push to GitHub
   ```

2. **Fork and clone the portfolio repository**
   ```bash
   git clone --recursive https://github.com/YOUR-USERNAME/portfolio.git
   cd portfolio
   git remote add upstream https://github.com/roughcutsoftware/portfolio.git
   ```

3. **Create a feature branch**
   ```bash
   git checkout -b add-csharp-async-tutorial
   ```

4. **Add your project as a submodule**
   ```bash
   git submodule add https://github.com/YOUR-USERNAME/csharp-async-tutorial.git learning-projects/csharp-async-tutorial
   ```

5. **Verify the submodule was added**
   ```bash
   git status
   cat .gitmodules
   ```

6. **Update the main README (optional but recommended)**
   - Add a brief description in the main README.md
   - Or update learning-projects/README.md

7. **Commit and push**
   ```bash
   git add .gitmodules learning-projects/csharp-async-tutorial
   git commit -m "Add C# async/await tutorial project

   - Covers async/await fundamentals
   - Includes practical examples
   - Demonstrates common patterns"
   
   git push origin add-csharp-async-tutorial
   ```

8. **Create a Pull Request on GitHub**
   - Go to your fork on GitHub
   - Click "Compare & pull request"
   - Fill in the description
   - Submit for review

---

## Updating an Existing Submodule Project

### Scenario
You've made improvements to an existing learning project and want to update it in the portfolio.

### Option A: You Own the Submodule Project

1. **Update the submodule project**
   ```bash
   cd learning-projects/csharp-basics
   
   # Make sure you're on the main branch
   git checkout main
   
   # Make your changes
   # ...
   
   # Commit and push
   git add .
   git commit -m "Improve error handling examples"
   git push origin main
   ```

2. **Update the parent repository**
   ```bash
   # Return to portfolio root
   cd ../..
   
   # Create a feature branch
   git checkout -b update-csharp-basics
   
   # Update the submodule reference
   git add learning-projects/csharp-basics
   git commit -m "Update csharp-basics to latest version"
   git push origin update-csharp-basics
   ```

3. **Create a Pull Request**

### Option B: Contributing to Someone Else's Submodule

1. **Fork the submodule repository on GitHub**

2. **Update your fork**
   ```bash
   cd learning-projects/csharp-basics
   
   # Add your fork as a remote
   git remote add myfork https://github.com/YOUR-USERNAME/csharp-basics.git
   
   # Create a feature branch
   git checkout -b improve-examples
   
   # Make your changes
   # ...
   
   # Commit and push to your fork
   git add .
   git commit -m "Improve error handling examples"
   git push myfork improve-examples
   ```

3. **Create a Pull Request to the original submodule repository**

4. **After it's merged, update the portfolio**
   ```bash
   cd ../..
   git checkout -b update-csharp-basics
   git submodule update --remote learning-projects/csharp-basics
   git add learning-projects/csharp-basics
   git commit -m "Update csharp-basics with improved examples"
   git push origin update-csharp-basics
   ```

---

## Creating a New Starter Template

### Scenario
You want to create a new ASP.NET Core API starter template for the portfolio.

### Steps

1. **Create the project locally**
   ```bash
   cd ~/my-projects
   mkdir aspnet-core-api-starter
   cd aspnet-core-api-starter
   
   # Create the solution and project
   dotnet new webapi -n ApiStarter
   dotnet new sln
   dotnet sln add ApiStarter/ApiStarter.csproj
   
   # Add additional setup (auth, logging, etc.)
   # ...
   ```

2. **Create comprehensive documentation**
   ```bash
   # Create README.md with:
   # - Project overview
   # - Features included
   # - Setup instructions
   # - Configuration guide
   # - Deployment tips
   ```

3. **Initialize Git and push to GitHub**
   ```bash
   git init
   git add .
   git commit -m "Initial commit: ASP.NET Core API starter template"
   
   # Create repository on GitHub
   git remote add origin https://github.com/YOUR-USERNAME/aspnet-core-api-starter.git
   git push -u origin main
   ```

4. **Add to portfolio as submodule**
   ```bash
   cd ~/portfolio
   git checkout -b add-aspnet-api-starter
   git submodule add https://github.com/YOUR-USERNAME/aspnet-core-api-starter.git starter-projects/aspnet-core-api-starter
   
   # Update documentation
   # Edit starter-projects/README.md to list your new template
   
   git add .
   git commit -m "Add ASP.NET Core API starter template"
   git push origin add-aspnet-api-starter
   ```

5. **Create Pull Request**

---

## Collaborating on a Project

### Scenario
Multiple people are working on improving a conceptual project.

### Initial Setup

1. **Clone the portfolio with submodules**
   ```bash
   git clone --recursive https://github.com/roughcutsoftware/portfolio.git
   cd portfolio
   ```

2. **Navigate to the project you want to work on**
   ```bash
   cd conceptual-projects/design-patterns
   git checkout main
   git pull
   ```

### Daily Workflow

1. **Before starting work, update everything**
   ```bash
   # Update portfolio
   cd ~/portfolio
   git pull --recurse-submodules
   
   # Update specific submodule
   cd conceptual-projects/design-patterns
   git checkout main
   git pull
   ```

2. **Create a feature branch**
   ```bash
   git checkout -b add-observer-pattern
   ```

3. **Work on your feature**
   ```bash
   # Make changes
   # Test your code
   # Commit regularly
   git add .
   git commit -m "Add Observer pattern implementation"
   ```

4. **Push your branch**
   ```bash
   git push origin add-observer-pattern
   ```

5. **Create Pull Request to the submodule repository**

6. **After merge, update the portfolio**
   ```bash
   cd ~/portfolio
   git checkout -b update-design-patterns
   git submodule update --remote conceptual-projects/design-patterns
   git add conceptual-projects/design-patterns
   git commit -m "Update design-patterns with Observer pattern"
   git push origin update-design-patterns
   ```

---

## Syncing Your Fork

### Scenario
The main portfolio repository has been updated and you want to sync your fork.

### Steps

1. **Add upstream if not already added**
   ```bash
   cd ~/portfolio
   git remote -v
   git remote add upstream https://github.com/roughcutsoftware/portfolio.git
   ```

2. **Fetch upstream changes**
   ```bash
   git fetch upstream
   ```

3. **Merge upstream into your main branch**
   ```bash
   git checkout main
   git merge upstream/main
   ```

4. **Update all submodules**
   ```bash
   git submodule update --init --recursive
   ```

5. **Push to your fork**
   ```bash
   git push origin main
   ```

6. **Update submodules to latest**
   ```bash
   # Optional: Update all submodules to their latest commits
   git submodule update --remote --merge
   git add .
   git commit -m "Update all submodules to latest versions"
   git push origin main
   ```

---

## Troubleshooting Common Issues

### Issue: Submodule is in Detached HEAD State

**Solution:**
```bash
cd <submodule-directory>
git checkout main
cd ..
git add <submodule-directory>
git commit -m "Update submodule to track main branch"
```

### Issue: Merge Conflict in .gitmodules

**Solution:**
```bash
# Open .gitmodules in an editor
# Resolve conflicts manually
git add .gitmodules
git commit -m "Resolve .gitmodules conflict"
```

### Issue: Submodule Changes Not Showing in Portfolio

**Solution:**
```bash
# Make sure changes are committed in the submodule
cd <submodule-directory>
git status
git log -1

# Return to portfolio and update reference
cd ..
git add <submodule-directory>
git commit -m "Update submodule reference"
```

### Issue: Cannot Push to Submodule

**Solution:**
```bash
cd <submodule-directory>

# Make sure you're on a branch, not detached HEAD
git checkout main

# If you don't have push access, fork first
git remote add myfork https://github.com/YOUR-USERNAME/project.git
git push myfork main
```

---

## Best Practices

1. **Always work on feature branches** - Never work directly on main
2. **Update frequently** - Pull changes before starting new work
3. **Commit often** - Small, focused commits are better
4. **Write clear commit messages** - Explain what and why
5. **Test before pushing** - Ensure code builds and tests pass
6. **Keep submodules updated** - Regularly update to latest versions
7. **Document your changes** - Update READMEs as needed
8. **Communicate with team** - Use issues and pull requests effectively

---

## Additional Resources

- [CONTRIBUTING.md](CONTRIBUTING.md) - Contribution guidelines
- [GIT_GUIDE.md](GIT_GUIDE.md) - Advanced Git concepts
- [QUICK_REFERENCE.md](QUICK_REFERENCE.md) - Quick command reference
