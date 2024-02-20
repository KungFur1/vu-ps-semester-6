#pragma once

class Date
{
private:
    int day, month, year;
public:
    Date(int day = 1, int month = 1, int year = 2024);
    ~Date();
    char Yo()
    {
        return 'Y';
    }
};