class Helmet
{
    private:
        float weight;
    public:
        float get_weight()
        {
            return weight;
        }
        void set_weight(float weight)
        {
            if (weight >= 0)
            {
                this->weight = weight;
            }
        }
        Helmet(float weight)
        {
            this->weight = weight;
        }
};