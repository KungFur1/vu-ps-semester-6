using namespace std;
#include <iostream>


struct B {
    int b;
    B(int i) {b = i;}
};

class F {
    B *b;
    public:
        F(int i) {b = new B(i);}
        ~F() {delete b;}
        int getB() const {return b->b;}

        // Copy constructor
        F(const F& f) {
            b = new B(f.getB());
        }

        // Assignment operator - assumes that the object is already created
        F& operator=(const F& f){
            if(this == &f) {
                return *this;
            }
            delete b;
            b = new B(f.getB());
            return *this;
        }
};

int main()
{
    cout << "Hello world.";

    F* f1 = new F(1);
    F f2(3);
    F f3 = f2;
    cout << f3.getB() << endl;
    cout << f2.getB() << endl;

    f2 = *f1;
    delete f1;
    cout << f2.getB() << endl;
    cout << f1->getB() << endl;

    return 0;
}
