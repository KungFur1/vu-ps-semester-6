// file "Triangle.h"
#ifndef TRIANGLE_H
#define TRIANGLE_H

namespace math {
    namespace geometry {
        class Triangle {
            private:
                float a, b, c;
            public:
                Triangle(float a, float b, float c);
                ~Triangle();
                float length();
        };
    }
}

#endif