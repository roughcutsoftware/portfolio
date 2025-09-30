# Advanced Git Concepts & Command Reference

This guide covers advanced Git concepts and provides practical command examples for working with this portfolio repository and Git submodules.

## Table of Contents
- [Git Submodules](#git-submodules)
- [Advanced Git Commands](#advanced-git-commands)
- [Branching Strategies](#branching-strategies)
- [Collaborative Workflows](#collaborative-workflows)
- [Troubleshooting](#troubleshooting)

---

## Git Submodules

### What are Git Submodules?

Git submodules allow you to keep a Git repository as a subdirectory of another Git repository. This lets you clone another repository into your project and keep your commits separate.

### Basic Submodule Commands

#### Adding a Submodule
```bash
# Add a new submodule to your repository
git submodule add <repository-url> <path>

# Example: Add a learning project
git submodule add https://github.com/username/csharp-basics.git learning-projects/csharp-basics

# Commit the changes
git add .gitmodules learning-projects/csharp-basics
git commit -m "Add C# basics learning project as submodule"
```

#### Cloning a Repository with Submodules
```bash
# Method 1: Clone with all submodules at once
git clone --recursive <repository-url>

# Method 2: Clone first, then initialize submodules
git clone <repository-url>
cd <repository>
git submodule init
git submodule update
```

#### Updating Submodules
```bash
# Update all submodules to the latest commit on their tracked branch
git submodule update --remote --merge

# Update a specific submodule
git submodule update --remote --merge learning-projects/csharp-basics

# Update submodules and initialize any new ones
git submodule update --init --recursive
```

#### Working Inside a Submodule
```bash
# Navigate into the submodule directory
cd learning-projects/csharp-basics

# Make changes, commit, and push (submodule is a full Git repository)
git checkout main
git pull
# Make your changes
git add .
git commit -m "Update lesson content"
git push

# Return to the parent repository
cd ../..

# The parent repository needs to track the new submodule commit
git add learning-projects/csharp-basics
git commit -m "Update csharp-basics submodule reference"
git push
```

#### Removing a Submodule
```bash
# 1. Deinitialize the submodule
git submodule deinit -f learning-projects/old-project

# 2. Remove the submodule from the repository
git rm -f learning-projects/old-project

# 3. Remove the submodule entry from .git/modules
rm -rf .git/modules/learning-projects/old-project

# 4. Commit the changes
git commit -m "Remove old-project submodule"
```

---

## Advanced Git Commands

### Interactive Rebase
```bash
# Rebase the last 5 commits interactively
git rebase -i HEAD~5

# Rebase onto another branch
git rebase -i main
```

### Cherry-Pick
```bash
# Apply a specific commit from another branch
git cherry-pick <commit-hash>

# Cherry-pick without committing (stage changes only)
git cherry-pick -n <commit-hash>

# Cherry-pick a range of commits
git cherry-pick <start-commit>..<end-commit>
```

### Stashing
```bash
# Save current changes and revert to clean working directory
git stash

# Save with a descriptive message
git stash save "WIP: feature implementation"

# List all stashes
git stash list

# Apply the most recent stash
git stash apply

# Apply and remove the stash
git stash pop

# Apply a specific stash
git stash apply stash@{2}

# Create a branch from a stash
git stash branch <branch-name> stash@{0}
```

### Reflog
```bash
# View the reference log (history of HEAD movements)
git reflog

# Recover a "lost" commit
git reflog
git checkout <commit-hash>
git branch recovery-branch

# Undo a rebase or reset
git reflog
git reset --hard <commit-before-rebase>
```

### Bisect (Binary Search for Bugs)
```bash
# Start bisecting
git bisect start

# Mark current commit as bad
git bisect bad

# Mark a known good commit
git bisect good <commit-hash>

# Git will checkout commits; test and mark each one
git bisect good  # if test passes
git bisect bad   # if test fails

# Reset after finding the bad commit
git bisect reset
```

### Worktrees
```bash
# Create a new working tree (work on multiple branches simultaneously)
git worktree add ../portfolio-feature feature-branch

# List all worktrees
git worktree list

# Remove a worktree
git worktree remove ../portfolio-feature
```

---

## Branching Strategies

### Feature Branch Workflow
```bash
# Create and switch to a new feature branch
git checkout -b feature/new-learning-project

# Work on your feature
# ...

# Push the feature branch
git push -u origin feature/new-learning-project

# After review, merge to main
git checkout main
git merge feature/new-learning-project
git push
```

### Git Flow
```bash
# Main branches: main (production), develop (integration)

# Start a new feature
git checkout -b feature/user-authentication develop

# Finish the feature
git checkout develop
git merge --no-ff feature/user-authentication
git branch -d feature/user-authentication

# Create a release branch
git checkout -b release/1.0.0 develop

# Finish the release
git checkout main
git merge --no-ff release/1.0.0
git tag -a v1.0.0 -m "Version 1.0.0"
git checkout develop
git merge --no-ff release/1.0.0
git branch -d release/1.0.0
```

---

## Collaborative Workflows

### Pull Request Workflow
```bash
# Fork and clone the repository
git clone <your-fork-url>
cd portfolio

# Add upstream remote
git remote add upstream https://github.com/roughcutsoftware/portfolio.git

# Create a feature branch
git checkout -b fix/documentation-typos

# Make changes and commit
git add .
git commit -m "Fix typos in README"

# Push to your fork
git push origin fix/documentation-typos

# Create Pull Request on GitHub
# After PR is merged, update your fork
git checkout main
git pull upstream main
git push origin main
```

### Syncing Forks
```bash
# Fetch upstream changes
git fetch upstream

# Merge upstream changes into your local main
git checkout main
git merge upstream/main

# Push to your fork
git push origin main
```

---

## Troubleshooting

### Submodule Issues

#### Submodule is in Detached HEAD State
```bash
cd <submodule-directory>
git checkout main  # or the appropriate branch
cd ..
git add <submodule-directory>
git commit -m "Update submodule to track main branch"
```

#### Submodule Update Conflicts
```bash
# If you have uncommitted changes in a submodule
cd <submodule-directory>
git stash
cd ..
git submodule update
cd <submodule-directory>
git stash pop
```

#### Reset Submodules to Committed State
```bash
# Reset all submodules to the exact state recorded in the parent repo
git submodule update --init --recursive --force
```

### General Git Issues

#### Undo Last Commit (Keep Changes)
```bash
git reset --soft HEAD~1
```

#### Undo Last Commit (Discard Changes)
```bash
git reset --hard HEAD~1
```

#### Fix Wrong Commit Message
```bash
# If you haven't pushed yet
git commit --amend -m "Corrected commit message"

# If you've already pushed (use with caution)
git commit --amend -m "Corrected commit message"
git push --force-with-lease
```

#### Recover Deleted Branch
```bash
git reflog
# Find the commit where the branch was deleted
git checkout -b recovered-branch <commit-hash>
```

---

## Best Practices

1. **Commit Often**: Make small, logical commits with clear messages
2. **Write Good Commit Messages**: Use imperative mood ("Add feature" not "Added feature")
3. **Pull Before Push**: Always pull the latest changes before pushing
4. **Use Branches**: Never work directly on main
5. **Review Changes**: Use `git diff` before committing
6. **Keep Submodules Updated**: Regularly update submodules to track important changes
7. **Document Your Workflow**: Keep team documentation up-to-date

## Additional Resources

- [Pro Git Book](https://git-scm.com/book/en/v2)
- [Git Submodules Documentation](https://git-scm.com/book/en/v2/Git-Tools-Submodules)
- [Atlassian Git Tutorials](https://www.atlassian.com/git/tutorials)
- [GitHub Docs](https://docs.github.com/en/get-started)
