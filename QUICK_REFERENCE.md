# Git Quick Reference

Quick reference card for common Git operations in this portfolio repository.

## Common Commands

### Cloning and Setup
```bash
# Clone with all submodules
git clone --recursive https://github.com/roughcutsoftware/portfolio.git

# Clone then initialize submodules
git clone https://github.com/roughcutsoftware/portfolio.git
cd portfolio
git submodule init
git submodule update
```

### Daily Operations
```bash
# Check status
git status

# View changes
git diff

# Stage changes
git add <file>
git add .

# Commit changes
git commit -m "Your message"

# Push to remote
git push

# Pull latest changes
git pull

# Pull with submodule updates
git pull --recurse-submodules
```

### Branch Operations
```bash
# Create new branch
git checkout -b feature/new-feature

# Switch branches
git checkout main

# List branches
git branch -a

# Delete local branch
git branch -d feature/old-feature

# Push new branch
git push -u origin feature/new-feature
```

### Submodule Commands
```bash
# Add submodule
git submodule add <url> <path>

# Update all submodules
git submodule update --remote --merge

# Update specific submodule
git submodule update --remote --merge <path>

# Initialize new submodules
git submodule update --init --recursive

# View submodule status
git submodule status

# Execute command in all submodules
git submodule foreach '<command>'
```

### Viewing History
```bash
# View commit history
git log
git log --oneline
git log --graph --oneline --all

# View file history
git log --follow <file>

# View changes in commit
git show <commit-hash>

# Search commits
git log --grep="search term"
```

### Undoing Changes
```bash
# Discard working directory changes
git checkout -- <file>
git restore <file>

# Unstage file
git reset HEAD <file>
git restore --staged <file>

# Undo last commit (keep changes)
git reset --soft HEAD~1

# Undo last commit (discard changes)
git reset --hard HEAD~1

# Revert a commit (creates new commit)
git revert <commit-hash>
```

### Stashing
```bash
# Save current work
git stash
git stash save "description"

# List stashes
git stash list

# Apply stash
git stash apply
git stash pop

# Apply specific stash
git stash apply stash@{n}

# Delete stash
git stash drop stash@{n}
```

### Remote Operations
```bash
# View remotes
git remote -v

# Add remote
git remote add <name> <url>

# Fetch from remote
git fetch origin

# Pull from remote
git pull origin main

# Push to remote
git push origin main

# Set upstream
git push -u origin feature-branch
```

### Tagging
```bash
# Create tag
git tag v1.0.0
git tag -a v1.0.0 -m "Version 1.0.0"

# List tags
git tag

# Push tag
git push origin v1.0.0
git push --tags

# Delete tag
git tag -d v1.0.0
git push origin :refs/tags/v1.0.0
```

### Submodule-Specific Operations
```bash
# Update submodules after pulling
git pull
git submodule update --init --recursive

# Make changes in submodule
cd <submodule-path>
git checkout main
# make changes
git add .
git commit -m "Update submodule"
git push
cd ..
git add <submodule-path>
git commit -m "Update submodule reference"
git push

# Remove submodule
git submodule deinit -f <path>
git rm -f <path>
rm -rf .git/modules/<path>
git commit -m "Remove submodule"
```

### Troubleshooting
```bash
# Reset submodules to recorded state
git submodule update --init --recursive --force

# Sync submodule URLs
git submodule sync

# View reflog (recover lost commits)
git reflog

# Clean untracked files (careful!)
git clean -fd

# Check Git configuration
git config --list
```

## Tips

- Always pull before starting new work
- Commit often with clear messages
- Use branches for new features
- Keep submodules updated
- Review changes before committing: `git diff`
- Use `git status` frequently

## Need More Help?

See [GIT_GUIDE.md](GIT_GUIDE.md) for detailed explanations and advanced usage.
