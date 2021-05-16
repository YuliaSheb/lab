#include "Mathematics.h"
int Sum(int a, int b) {
	return a + b;
}
int Pow(int a, int deg) {
	int value = 1;
	while (deg--)
		value *= a;
	return value;
}
int Multiply (int a, int b) {
return a * b;	
}	
int Divide(int a, int b) {
return a / b;	
}	
int Mod(int a, int b) {		
return a % b;	
}