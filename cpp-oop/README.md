# cpp-oop
Object oriented programming using c++. This university module has a requirement for all projects to have a repository on internal VU gitlab. To have it both in my github repo and in VU gitlab I will be using git submodules.

## Git Submodules Basic Commands

- `git submodule add [URL] [directory]`: Add a new submodule.
- `git submodule init`: Creates the version control files for the submodule that you are in.
- `git submodule update`: Updates the files to match the commit that the .gitmodules is pointing to.
- `git submodule sync`: Synchronizes the urls of .git/config and .gitmodules.
- `git add <submodule directory>`: Use this after pushing changes in the submodule, to have it reflected in the .gitmodules, commit after this command.
- `git clone --recurse-submodules [URL]`: Clone a repository and its submodules.
- `git fetch --recurse-submodules`: Fetch new changes from the submodule remotes.
- `git submodule status`: Show the status of the submodules.
- Removing a Submodule:
  - Delete section from **.gitmodules**.
  - Delete section from **.git/config**.
  - `git rm --cached [path-to-submodule]`: Remove submodule path from tracking.
  - Commit and delete untracked submodule files.