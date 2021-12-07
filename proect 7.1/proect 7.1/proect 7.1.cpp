//#include "stdafx.h"
#include <stdio.h>
#include <stdlib.h>
#include<locale.h>
#include<string.h>
#define _CRT_SECURE_NO_WARNINGS

int x[50][50];
void vvod(int x[50][50], int n1, int m1);
int vivod(int x[50][50], int n1, int m1);
int Zad1(int x[50][50], int n1, int m1);
int Zad2(char str[80]);

void Menu()
{

	
		printf("\n Меню:\n");
		printf("1.Ввести новый массив:\n");
		printf("2.Задание 1:\n");
		printf("3.Вывод массива:\n");
		printf("4.Задание 2:\n");
		printf("5.Выход:\n");
}
int main()
{
	setlocale(LC_ALL, "Rus");
	int n, m, sum = 0;
	char str[80];

	while (true)
	{
		Menu();
		int s;
		printf("\n Введите номер\n");
		scanf_s("%d", &s);
		switch (s)
		{
		case 1:printf("\n Введите n\n");
			scanf_s("%d", &n);
			printf("Введите m\n");
			scanf_s("%d", &m);
			vvod(x, n, m);
			break;
		case 2: Zad1(x, n, m); 
			break;
		case 3:vivod(x, n, m);
			break;
		case 4: printf("\nВведите строку:    ");
			fgets(str, 80, stdin);
			puts(str);
			Zad2(str); 
			break;
		case 5:exit(0); break;
		default:printf("Нет такого значения");
		}
	}
}

void vvod(int x[50][50], int n1, int m1)
{
	int z, j;
	for (z = 0; z < n1; z++)
		for (j = 0; j < m1; j++) {
			printf("Введите элемент [%d,%d]\n", z + 1, j + 1);
			scanf_s("%d", &x[z][j]);
		}
}
int vivod(int x[50][50], int n1, int m1)
{
	int z, j;
	printf("\n");
	for (z = 0; z < n1; z++) {
		for (j = 0; j < m1; j++)
			printf("%d ", x[z][j]);
		printf("\n");
	}
	return 0;
}
int Zad1(int x[50][50], int n1, int m1)
{
	int k = 0, kol = 0;
	int z, j;
	for (z = 0; z < n1; z++)
	{
		for (int j = 0; j < m1; j++)
		{
			if (x[z][j] >= 0)
			{
				kol++;
				k = j;
				break;
			}

		}

	}
	if (kol == n1)
	{

		printf("\n1 положительный столбец=%d \n", k);
	}
	else
	{
		printf("\nнет положительных столбцов\n");
	}
	if (k == 0)
	{
		printf( "\nнет предыдущих столбцов");

	}
	else
	{
		for (int z = 0; z < n1; z++)
		{

			x[z][k - 1] = -x[z][k - 1];
			printf("%d\n", x[z][k - 1]);
		}
	}
	return 0;
}
	int Zad2( char str[80])
	{
			char i = 0;
			int sum = 0;
			
			while (str[i] && str[i] != '\n')
			{
				if (str[i] >= '0' && str[i] <= '9')
					sum += str[i] - '0';
				i++;
			}

			printf("Сумма цифр=%d\n", sum);
			return 0;
	}

