#include <iostream>
using namespace std;


class Number {
public:
    int value;
public:
    Number(int initialValue = 0) : value(initialValue) {}
    Number& operator++() {
        ++value;
        return *this;
    }
    Number operator++(int) {
        Number temp = *this; // Creates a new object before incrementation
        ++value; // Increments the old object
        return temp; // Returns the new object (with the smaller value)
    }
};
int main() {
    Number num(5);
    cout << (++num).value << endl;
    cout << (num).value << endl;

    cout << (num++).value << endl;
    cout << (num).value << endl;
    return 0;
}


/*
int main(){

    const Example e;
    //int final = e.getFinal();
    return 0;
}


class Example
{
    private:
        const int finalField;
        int usualField;
    public:
        Example() :finalField(1) { }
        //void setFinal(int final) { finalField = final; }
        int getFinal() { return finalField; }
        int getUsual() const { return usualField; } // If we declare Example e as const, we need to specify which methods dont change anything
};
*/