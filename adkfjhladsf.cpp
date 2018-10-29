#include <iostream>

using namespace std;

//FUNCTION PROTOTYPES



int main()
{
    ifstream inFile;
    inFile.open("metro-bike-share-trip-data.csv", ios::in | ios::binary);

    if(!inFile)
        cout << "File opened incorrectly" << endl;

    ofstream outFile;
    outFile.open("out.csv", ios::out);


}
