#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

//FUNCTION PROTOTYPES

bool readLine(ifstream & inFile, ofstream & outFile);
void showState(ifstream & theFile);


int main()
{
    ifstream inFile;
    inFile.open("metro-bike-share-trip-data.csv", ios::in | ios::binary);
    showState(inFile);


    ofstream outFile;
    outFile.open("out.csv", ios::out | ios::binary);

    int maxRows = 132428;
    bool check = false;


    for(int i = 0; i<maxRows; i++)
    {

        if(i!=0)
        {
            check = readLine(inFile, outFile);
            if(!check)
            {
                cout << "ERROR ON LINE " << (maxRows+1) << endl;            //exit(101);
            }
        }
    }

    inFile.close();
    outFile.close();

}

bool readLine(ifstream & inFile, ofstream & outFile)
{
    int col = 14;
    bool check = false;
    int i;

    double latOne = 0;
    double latTwo = 0;
    double longOne = 0;
    double longTwo = 0;
    string holder = 0;

    for(i =0; i < col; i++)
    {
        getline(inFile, holder);
        //cout << holder << " ";
    }
     if(i == 14)
        return true;

    return false;
}

// for debugging
void showState(ifstream &theFile)
{
	cout << "File Status:\n";
	cout << " eof bit: " << theFile.eof() << endl;
	cout << " fail bit: " << theFile.fail() << endl;
	cout << " bad bit: " << theFile.bad() << endl;
	cout << " good bit: " << theFile.good() << endl << endl;
}
