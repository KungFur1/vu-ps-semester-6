# My university projects repository for 6th semester

## Courses
Each course will have its dedicated repository, with a coresponding README and other info. The courses I am taking this semester are:
* GMM - deep learning.
* PSK - software systems.
* PST - software testing.
* cpp-oop - object oriented programming using c++.
* rethorics - a non-programming class about speaking.

## Cloning Repository

### Clone the repository **without** cpp-oop
If you dont want to download cpp-oop content just use:

`git clone https://github.com/KungFur1/vu-ps-semester-6.git`

### Clone the repository **with** cpp-oop
If you do want to download cpp-oop content, the process is a bit different. Due to cpp-oop requirements we must publish all our tasks to internal Vilnius University GitLab (only accessible through VU internal network). You can access this network using a VPN, there are instructions on VU website, on how to do that, but this network is only accessible to VU students/employees. Finally, to include the repositories hosted on VU gitlab into this repository, I use git submodules.

So the steps to **clone the repository + the submodules**:
- Connect to **VU VPN**.
- `git clone --recurse-submodules https://github.com/KungFur1/vu-ps-semester-6.git`