# Advanced Git Topics & Concepts (with Examples)

1. **Branching Strategies**
   - Use feature, release, and hotfix branches to organize work.
   - Example:
```sh
git checkout -b feature/user-auth
git checkout -b release/1.0.0
git checkout -b hotfix/urgent-bug
```

2. **Rebasing**
   - Moves or combines a sequence of commits to a new base commit.
   - Example:
```sh
git checkout feature/user-auth
    git rebase main
```
   - Interactive rebase (squash, edit, reorder):
```sh
git rebase -i HEAD~3
```

3. **Submodules**
   - Embed another Git repository inside your repo.
   - Example:
```sh
git submodule add https://github.com/example/lib.git libs/lib
git submodule update --init --recursive
```

4. **Cherry-Pick**
   - Apply a specific commit from one branch onto another.
   - Example:
```sh
git cherry-pick <commit-hash>
```

5. **Stash**
   - Temporarily save changes that are not ready to commit.
   - Example:
```sh
git stash
git stash pop
```

6. **Reflog**
   - Shows a log of all changes to HEAD, including those not in history.
   - Example:
```sh
git reflog
```

7. **Hooks**
   - Scripts that run at certain points in the Git workflow (e.g., pre-commit, post-merge).
   - Example:  
     Place a script in `.git/hooks/pre-commit` to run checks before each commit.

8. **Conflict Resolution**
   - Merge conflicts occur when changes overlap; must be resolved manually.
   - Example:
```sh
git status
git mergetool
```
   - Or use your IDE’s merge tool.

9. **Fast-Forward vs. Non-Fast-Forward Merges**
   - Fast-forward: branch pointer moves forward, no new commit.
   - Non-fast-forward: creates a merge commit, preserving branch history.
   - Example:
```sh
git merge --no-ff feature/user-auth
```

---

**Tip:**  
Practice these commands and workflows in a test repository to get comfortable. Advanced Git skills help you collaborate efficiently, keep history clean, and recover from mistakes.
