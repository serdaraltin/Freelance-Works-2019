/***************************
Student Number : 040100411
Student Name   : Ilker Kesen
Course         : BLG252E
CRN            : 11694
Term           : 2015-Fall
Homework       : #2
***************************/

#include <iostream>
#include <iomanip>
#include <fstream>

#define SIZE 200
#define FILENAME "SUBSCRIBERS.TXT"
#define S_QUOTA 5000
#define IT_QUOTA 100
#define IN_QUOTA 400
#define IP_QUOTA 2000

using namespace std;


// Subscriber class
class Subscriber {
    public:
        Subscriber(int, string, string, int, int);
        float compute_remaining();
        virtual void print();
        virtual string get_subscriber_type() = 0;
    protected:
        int ID;
        string fname;
        string lname;
        int consumption_amount;
        int allowed_quota;
};


// Individual class
class Individual : public Subscriber {
    public:
        Individual(int, string, string, int, int, string);
        string get_subscriber_type();
    private:
        string option_code;
};


// Institutional class
class Institutional : public Subscriber {
    public:
        Institutional(int, string, string, int, int, string);
        string get_subscriber_type();
        virtual void print();
    private:
        string Institution_name;
};


// main program
int main(int argc, char** argv)
{
    Subscriber *subscribers[SIZE] = {NULL};
    ifstream file(FILENAME);

    string subscriber_type, fname, lname, institution;
    int ID, consumption;

    if (!file.is_open()) {
        cout << "File cannot be opened." << endl;
        return -1;
    }

    for (int i = 0; !file.eof(); i++) {
        file >> subscriber_type;
        if (file.eof()) break;

        file >> ID;
        if (file.eof()) break;

        file >> fname;
        if (file.eof()) break;

        file >> lname;
        if (file.eof()) break;

        // check after all data reads, except the last one.
        // actually, only one condition at for statement should be enough.
        // however, last entry is read twice. so, I added extra controls.
        // why? because of extra spaces at the end of the input file.
        file >> consumption;

        if (subscriber_type == "S") {
            file >> institution;
            subscribers[i] = new Institutional(
                ID, fname, lname, consumption, S_QUOTA, institution);
        }
        else if (subscriber_type == "IT") {
            subscribers[i] = new Individual(
                ID, fname, lname, consumption, IT_QUOTA, subscriber_type);
        }
        else if (subscriber_type == "IN") {
            subscribers[i] = new Individual(
                ID, fname, lname, consumption, IN_QUOTA, subscriber_type);
        }
        else if (subscriber_type == "IP") {
            subscribers[i] = new Individual(
                ID, fname, lname, consumption, IP_QUOTA, subscriber_type);
        }
    }

    cout << "List of Institutional Subscribers:" << endl;
    cout << left << setw(8) << "ID";
    cout << left << setw(14) << "FirstName";
    cout << left << setw(14) << "LastName";
    cout << left << setw(17) << "InstitutionName";
    cout << left << setw(15) << "RemainingAmount";
    cout << endl;
    for (int i = 0; subscribers[i] != NULL; i++) {
        if (subscribers[i]->get_subscriber_type() == "S")
            subscribers[i]->print();
    }
    cout << endl;

    cout << "List of Individual-Trial Subscribers:" << endl;
    cout << left << setw(8) << "ID";
    cout << left << setw(14) << "FirstName";
    cout << left << setw(14) << "LastName";
    cout << left << setw(15) << "RemainingAmount";
    cout << endl;
    for (int i = 0; subscribers[i] != NULL; i++) {
        if (subscribers[i]->get_subscriber_type() == "IT")
            subscribers[i]->print();
    }
    cout << endl;

    cout << "List of Individual-Normal Subscribers:" << endl;
    cout << left << setw(8) << "ID";
    cout << left << setw(14) << "FirstName";
    cout << left << setw(14) << "LastName";
    cout << left << setw(15) << "RemainingAmount";
    cout << endl;
    for (int i = 0; subscribers[i] != NULL; i++) {
        if (subscribers[i]->get_subscriber_type() == "IN")
            subscribers[i]->print();
    }
    cout << endl;

    cout << "List of Individual-Premium Subscribers:" << endl;
    cout << left << setw(8) << "ID";
    cout << left << setw(14) << "FirstName";
    cout << left << setw(14) << "LastName";
    cout << left << setw(15) << "RemainingAmount";
    cout << endl;
    for (int i = 0; subscribers[i] != NULL; i++) {
        if (subscribers[i]->get_subscriber_type() == "IP")
            subscribers[i]->print();
    }
    cout << endl;

    // close file and deallocate memory
    file.close();
    for (int i = 0; subscribers[i] != NULL; i++) {
        delete subscribers[i];
        subscribers[i] = NULL;
    }

    // prevent sudden termination on Windows
    cout << "Press enter to exit..." << endl;
    int ch = cin.get();
    return 0;
}


// Subscriber constructor
Subscriber::Subscriber(
    int ID, string fname, string lname, int consumption_amount, int allowed_quota) :
    ID(ID),
    fname(fname),
    lname(lname),
    consumption_amount(consumption_amount),
    allowed_quota(allowed_quota)
{}

// calculates the remaining amount
float Subscriber::compute_remaining()
{
    return allowed_quota - consumption_amount;
}


// prints information about Subscriber object
void Subscriber::print()
{
    cout << left << setw(8) << ID;
    cout << left << setw(14) << fname;
    cout << left << setw(14) << lname;
    cout << left << setw(15) << compute_remaining();
    cout << endl;
}


// Individual constructor
Individual::Individual(int ID, string fname, string lname, int consumption_amount,
    int allowed_quota, string option_code) :
    Subscriber(ID, fname, lname, consumption_amount, allowed_quota), option_code(option_code)
{}


// returns subscriber type for Individual
string Individual::get_subscriber_type()
{
    return option_code;
}


// Institutional constructor
Institutional::Institutional(int ID, string fname, string lname, int consumption_amount,
    int allowed_quota, string Institution_name) :
    Subscriber(ID, fname, lname, consumption_amount, allowed_quota),
    Institution_name(Institution_name)
{}


// returns subscriber type for Institutional
string Institutional::get_subscriber_type()
{
    return string("S");
}


// prints information about Institutional object
void Institutional::print()
{
    cout << left << setw(8) << ID;
    cout << left << setw(14) << fname;
    cout << left << setw(14) << lname;
    cout << left << setw(17) << Institution_name;
    cout << left << setw(15) << compute_remaining();
    cout << endl;
}
