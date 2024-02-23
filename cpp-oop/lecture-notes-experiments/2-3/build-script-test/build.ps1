# CLI scripts, the most primitive way of automating the build process
# To run this powershell script: ./build.ps1
g++ -c -std=c++20 .\A.cpp .\B.cpp
g++ -std=c++20 A.o B.o