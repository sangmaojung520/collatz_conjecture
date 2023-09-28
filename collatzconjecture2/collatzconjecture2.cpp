#include <iostream>

using namespace std;

int main() {
	float i = 0;

	cout << "Enter a positive integer: ";
	cin >> i;

	if (i - (int)i == 0 && i > 0) {
		int n;
		n = i;

		if (n > 0) {

			while (n != 1) {

				if (n % 2 == 0) {  // if the remainder of n/2 is 0,
									  // that is, if n is even
					n = n / 2;
				}
				else {
					n = 3 * n + 1;
				}

				// print a space followed by the new number
				cout << " " << n;
			}
			cout << endl;
		}

	}

	else {
		cout << "Please Enter a positive integer." << endl;
	}

	return 0;
}
