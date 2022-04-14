#include <iostream>
#include <stdlib.h>
#include "mpi.h"
using namespace std;
int main(int argc, char* argv[])
{
	int numprocs, myid;
	int* a, * b, * c;
	int n, p, l;
	int N = 10;
	MPI_Init(&argc, &argv);
	MPI_Comm_size(MPI_COMM_WORLD, &numprocs);
	MPI_Comm_rank(MPI_COMM_WORLD, &myid);
	MPI_Status status;
	if (myid == 0) {
		a = new int[N * N];
		b = new int[N];
		c = new int[N];
		for (int i = 0; i < N; i++) {
			b[i] = 1;
		}
		for (int j = 0; j < N * N; j++) {
				a[j] = 1;
		}
		n = int(N / numprocs);
		for (int k = 1; k < numprocs; k++) {
			MPI_Send(&n, 1, MPI_INT, k, 0, MPI_COMM_WORLD);
			MPI_Send(&a[k * n * N], n * N, MPI_INT, k, 1, MPI_COMM_WORLD);
			MPI_Send(&b[0], N, MPI_INT, k, 2, MPI_COMM_WORLD);
		}
	}
	else {
		MPI_Recv(&n, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, &status);
		a = new int[n * N];
		b = new int[N];
		c = new int[n];
		MPI_Recv(a, n * N, MPI_INT, 0, 1, MPI_COMM_WORLD, &status);
		MPI_Recv(b, N, MPI_INT, 0, 2, MPI_COMM_WORLD, &status);
	}
	MPI_Barrier(MPI_COMM_WORLD);
	for (int i = 0; i < n; i++) {
		c[i] = 0;
	}
	MPI_Barrier(MPI_COMM_WORLD);
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < N; j++) {
			c[i] += a[j + i * n] * b[j];
		}
	}
	MPI_Barrier(MPI_COMM_WORLD);
	if (myid == 0) {
		for (int i = 1; i < numprocs; i++) {
			MPI_Recv(&c[i * n], n, MPI_INT, i, 3, MPI_COMM_WORLD, &status);
		}
	}
	else {
		MPI_Send(c, n, MPI_INT, 0, 3, MPI_COMM_WORLD);
	}
	if (myid == 0) {
		for (int i = 0; i < N; i++) {
			printf("%d\n", c[i]);
		}
	}
	return 0;
}