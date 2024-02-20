rooster.exe: main.o Helmet.o Date.o
	g++ main.o Helmet.o Date.o -o rooster.exe -std=c++20

# -c to get object output
main.o: main.cpp
	g++ -c main.cpp -std=c++20

Helmet.o: Helmet.cpp
	g++ -c Helmet.cpp -std=c++20

Date.o: Time/Date.cpp
	g++ -c Time/Date.cpp -std=c++20

clean:
	del *.o rooster.exe