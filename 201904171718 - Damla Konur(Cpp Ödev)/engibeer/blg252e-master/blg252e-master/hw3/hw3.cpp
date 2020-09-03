/***************************
Student Number : 040100411
Student Name   : Ilker Kesen
Course         : BLG252E
CRN            : 11694
Term           : 2015-Fall
Homework       : #3
***************************/

#include <iostream>
#include <iomanip>
#include <sstream>
#include <fstream>
#include <vector>
#include <map>
#include <cmath>

#define CITIES_FILE "CITIES.TXT"
#define LINES_FILE "LINES.TXT"

using namespace std;


// CityDistance struct
struct CityDistance {
    int city_code;
    int city_distance;
};


// Line class
class Line {
    public:
        Line(int, string, string, vector<CityDistance>);
        void print_schedule(int, int);
        int line_code;
        string line_name;
        string line_craft_type;
        vector<CityDistance> line_cities;
        int average_speed;
};


map<int, string> cities;

int main(int argc, char** argv)
{
    try {
        vector<Line> lines;
        int city_code;
        string city_name;

        // cities file reading process
        ifstream cities_file(CITIES_FILE);
        if (!cities_file.is_open())
            throw "CITIES.TXT cannot be opened.";

        for (;!cities_file.eof();) {
            cities_file >> city_code;
            cities_file >> city_name;
            cities[city_code] = city_name;
        }

        cities_file.close();

        // lines file reading process
        ifstream lines_file(LINES_FILE);
        if (!lines_file.is_open())
            throw "LINES.TXT cannot be opened.";
        
        for (;!lines_file.eof();) {
            int line_code, cities_length;
            string line_name, line_craft_type;
            vector<CityDistance> line_cities;
            CityDistance dist;

            lines_file >> line_code;
            lines_file >> line_name;
            lines_file >> line_craft_type;
            lines_file >> cities_length;

            for (int i = 0; i < cities_length; i++) {
                lines_file >> dist.city_code;
                lines_file >> dist.city_distance;    

                if (cities.count(dist.city_code) == 0)
                    throw "Invalid city.";
                else
                    line_cities.push_back(dist);
            }

            Line new_line(line_code, line_name, line_craft_type, line_cities);
            lines.push_back(new_line);
        }

        lines_file.close();

        // LINES MENU
        cout << "LINES MENU" << endl << endl;
        cout << left << setw(11) << "Line_code";
        cout << left << setw(11) << "Line_name";
        cout << left << setw(15) << "Line_craft_type";
        cout << endl;

        for (int i = 0; i < lines.size(); i++) {
            cout << left << setw(11) << lines[i].line_code;
            cout << left << setw(11) << lines[i].line_name;
            cout << left << setw(11) << lines[i].line_craft_type;
            cout << endl;
        }

        int line_code; 
        cout << endl << "Enter Line Code : ";
        cin >> line_code;

        if (cin.fail())
            throw "Invalid line_code.";

        bool found = false;
        int k = 0;
        for (int i = 0; i < lines.size(); i++) {
            if (lines[i].line_code == line_code) {
                k = i;
                found = true;
                break;
            }
        }

        if (!found)
            throw "Invalid line_code.";

        // CITIES ON SELECTED LINE
        cout << endl << "CITIES ON SELECTED LINE" << endl << endl;

        cout << left << setw(11) << "City_code";
        cout << left << setw(11) << "City_name";
        cout << left << setw(10) << "Distance";
        cout << endl;

        for (int i = 0; i < (lines[k].line_cities).size(); i++) {
            cout << left << setw(11) << lines[k].line_cities[i].city_code;
            cout << left << setw(11) << cities[lines[k].line_cities[i].city_code];
            cout << left << setw(10) << lines[k].line_cities[i].city_distance;
            cout << endl;
        }

        int start_city_code, end_city_code;
        cout << endl << "Enter Start City code and End City code : ";
        cin >> start_city_code;
        cin >> end_city_code;

        if (cin.fail())
            throw "Invalid input (must be integer).";

        lines[k].print_schedule(start_city_code, end_city_code); 
    }
    catch (const char* exception) {
        cout << "Program has been stopped." << endl;
        cout << "Exception: " << exception << endl;
    }

    return 0;
}

// Line constructor
Line::Line(int line_code, string line_name, string line_craft_type,
    vector<CityDistance> line_cities) :
    line_code(line_code), line_name(line_name), line_craft_type(line_craft_type),
    line_cities(line_cities)
{
    if (line_craft_type == "Boeing")
        average_speed = 600;
    else if (line_craft_type == "Airbus")
        average_speed = 750;
    else if (line_craft_type == "Jetfly")
        average_speed = 700;
    else if (line_craft_type == "Lockheed")
        average_speed = 650;
    else
        throw "Invalid line_craft_type value (at Line object creation).";
}

// Line - prints schedule
void Line::print_schedule(int start_city_code, int end_city_code)
{
    int si = -1;
    int ei = -1; 
    for (int i = 0; i < line_cities.size(); i++) {
        if (line_cities[i].city_code == start_city_code)
            si = i;
        if (line_cities[i].city_code == end_city_code)
            ei = i;
        if (si != -1 && ei != -1)
            break;
    }
    
    if (si == -1)
        throw "Invalid start city code.";
    
    if (ei == -1)
        throw "Invalid end city code.";
    
    if (si == ei)
        throw "Start and end cities are same.";
    
    if (si > ei)
        throw "Start city must be before end city";

    cout << left << setw(16) << "Departure_City";
    cout << left << setw(16) << "Departure_Time";
    cout << left << setw(14) << "Arrival_City";
    cout << left << setw(14) << "Arrival_Time";
    cout << left << setw(14) << "Distance(Km)";
    cout << left << setw(24) << "Travel Duration(Hours)";
    cout << endl;

    cout << left << setw(16) << "==============";
    cout << left << setw(16) << "==============";
    cout << left << setw(14) << "============";
    cout << left << setw(14) << "============";
    cout << left << setw(14) << "============";
    cout << left << setw(24) << "======================";
    cout << endl;

    int hour = 7;
    int total_hours = 0;
    int total_distance = 0;
    for (int i = 0; i < ei; i++) {
        int duration = floor(line_cities[i+1].city_distance / float(average_speed));
        if (i < si) {
            hour = (hour + duration + 1) % 24;
            continue;
        }

        total_hours += duration;
        total_distance += line_cities[i+1].city_distance;

        int start_hour = (hour % 24 == 0) ? 24 : hour % 24;
        int end_hour = ((hour + duration) % 24 == 0) ? 24 : (hour + duration) % 24;

        ostringstream dt, at;
        if (start_hour < 10)
            dt << "0";
        if (end_hour < 10)
            at << "0";

        dt << start_hour << ":00";
        at << end_hour << ":00";
        hour = (hour + duration + 1) % 24;

        cout << left << setw(16) << cities[line_cities[i].city_code];
        cout << left << setw(16) << dt.str();
        cout << left << setw(14) << cities[line_cities[i+1].city_code];
        cout << left << setw(14) << at.str();
        cout << left << setw(14) << line_cities[i+1].city_distance;
        cout << left << setw(24) << duration; 
        cout << endl;
    }

    cout << endl << "TOTAL DISTANCE (Km) =  " << total_distance << endl;
    cout << "TOTAL HOURS = " << total_hours << endl;
}
