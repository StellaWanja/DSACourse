//Big O/ Asymptotic Analysis
//O(1)-constant time
//eg inserting a node at the beginning of a linked list

//O(n)-linear time, the larger the data set, the longer an algo takes,but increase in time will be constant
//eg looping through a data set

//O(n^2)-Quadratic time-increase in time that is proportional to the square of the data set
//eg nested loops

//O(2^n)-Exponential time - inefficient time than quadratic
//eg recursive fibonacci

//O(log n)-logarthmic time-where size of data set is halved
//eg binary search

//O(n log n)-linear logarithmic time
//eg merge and quick sort

//When comparing algorithms
//1. Different steps get added eg O(a+b) fn(){fn1(); fn2();}
//2. Drop constants eg O(2n) = O(n)
//3. Different inputs/ variables = O(ab) eg nested loops of different arrays
//4. Drop non-dominant terms eg O(n^2 + n) = O(n^2)
//5. Addition of runtime for different inputs = O(a+b)
int[] a = {1,2,3,4};
int[] b = {1,2,3,4};

for(int i=0; i<a.Length; i++){
    System.Console.WriteLine(i);
}

for(int i=0; i<b.Length; i++){
    System.Console.WriteLine(i);
}

//6. Multiplication of different inputs = O(a*b)
for(int i=0; i<a.Length; i++){
    for(int j=0; j<b.Length; j++){
        System.Console.WriteLine(i+j);
    }
}

//7. In recursive functions that make multiple calls, the runtime will often look like O(branches^depth)
//The braches is the number of times of each recurasive call
//eg
int f(int n){
    if (n <= 1) {
        return 1;
    }
    return f(n - 1) + f(n - 1);
}
//Runtime will be O(2^n)
//                  f(4)
//                 /     \
//                f(3)      f(3)
//              /     \      /   \
//            f(2)   f(2)   f(2)   f(2)
//           /  \    /      / \      /  \    
//        f(1) f(1) f(1) f(1) f(1) f(1) f(1)
//
// Level |  Nodes  |  Expression
//   0        1          2^0
//   1        2          2^1
//   2        4          2^2
//   3        8          2^3
