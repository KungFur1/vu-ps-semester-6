// file "Circle.h"
#ifndef CIRCLE_H
#define CIRCLE_H

namespace math {
    namespace geometry {
        class Circle {
            private:
                const float PI = 3.14f;
                float radius;
            public:
                Circle(float radius);
                ~Circle();
                float length();
        };
    }
}

#endif