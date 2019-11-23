/* Dynamic Programming C/C++ implementation of LCS problem */
#include<iostream>
#include<cstdlib>
#include<string>
#include<conio.h>
using namespace std;

void LCS(int Point1[], int Point2[],int m, int n)
{

	int** L = new int*[m + 1];

	for (int i = 0; i < m+1; i++)
	{
		L[i] = new int[n + 1];
	}
	int count = 0;
	for (int i = 0; i < m + 1; i++)
	{
		for (int j = 0; j < n + 1; j++)
		{
			L[i][j] = count;
			count++;
		}
	}
	for (int i = 0; i < m + 1; i++)
	{
		for (int j = 0; j < n + 1; j++)
		{
			cout << L[i][j];
		}
		cout << endl;
	}

}

int main()
{
	const int m = 5;
	int Point1[m] = { 1,2,3,4,5};
	const int n = 3;
	int Point2[n] = { 1,3,5};
	LCS(Point1, Point2, m, n);
	_getch();
	return 0;
}