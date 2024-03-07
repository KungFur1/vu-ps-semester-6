# Lecture 4

`const` - only allows to set initial value. Doesnt allow setting afterwards. (Throws compiler error)
```cpp
const struct {int x, y;} t = {3, 4};
```
If we declare Example e as const, we need to specify which methods dont change anything and mark them as `const`, in order to use them.
```cpp
int main(){
    const Example e;
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
        int getUsual() const { return usualField; }
        void setUsual(int usual) const { usualField = usual; } // Compiler error
}
```

```cpp
void passByValue(BigObject obj) {/* use obj */}
void passByConstReference(const BigObject &obj) {/* use obj */} // This doesnt copy the BigObject and doesnt allow to change it.
```

The same applies to `return`:
```cpp
BigObject returnLocalValue()
{
    BigObject bo;
    return bo;
}
BigObject& returnLocalReference() // This is bad because you return a reference to a no longer existing variable
{
    BigObject bo;
    return bo;
}
```

## Operator Overloading

Operator overload functions can be defined both inside the class and outside:
```cpp
struct Number {
    int value;
    Number(int value) {this->value = value;}
    Number operator-(const Number &n2) const {
        Number n;
        n.value = this->value - n2.value;
        return n;
    }
    friend ostream& operator<<(ostream& o, const Number &num); // friend is able to access private fields, bad looses encapsulation
}

// This is better because you can do operator overloading with different types
Number operator+(const Number &n1, const Number &n2) {
    Number n;
    n.value = n1.value + n2.value;
    return n;
}

ostream& operator<<(ostream& o, const Number &num){
    o << num.value;
    return o;
}

// Finally the code turns to this:
int main(){
    operator+(n, m); // n + m
    n.operator-(m); // n - m

    // Its a bit weird with ++n, n++ pre and post increment/decrement operators, because they have the same declaration
    // Therefore the post increment/decrement has an extra int parameter (the int can be any value) 
    n.operator++(); // pre
    n.operator++(500); // post, the value doesnt matter
}
```

Its better to use pre increment, because post increment makes a copy of the object, returns it and increments the original object.

**Proper pre/post increment implementation**
```cpp
class Number {
private:
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
    ++num;
    num.display();
    num++;
    return 0;
}

```