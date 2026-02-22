# Sorting Algorithms Benchmark & Visualizer

A Windows Forms desktop application developed in **C# (.NET)** designed to benchmark, compare, and visualize the performance of various sorting algorithms. 

This project demonstrates practical applications of algorithmic time complexity ($O(n^2)$ vs $O(n \log n)$), Object-Oriented Programming principles, and asynchronous UI handling.

## Key Features

* **Dynamic Data Generation:** Users can generate random datasets ranging from 1,000 to 100,000 elements to test scalability.
* **High-Precision Benchmarking:** Utilizes the `System.Diagnostics.Stopwatch` class for accurate execution time tracking at the millisecond level.
* **Responsive UI (Asynchronous Programming):** Heavy sorting computations are offloaded to background threads using `async / await` and `Task.Run`, preventing UI freezing during operations.
* **Dynamic Data Visualization:** Results are visually represented in real-time using dynamically generated UI horizontal bars proportional to the execution time.

## Analyzed Algorithms

The application compares 6 algorithms categorized by their theoretical time complexity:

### Quadratic Complexity - $O(n^2)$
1. **Bubble Sort** - Highly inefficient, used primarily as a baseline.
2. **Insertion Sort** - Efficient for small or partially sorted datasets.
3. **Selection Sort** - Performs a minimum number of memory writes (swaps).

### Logarithmic Complexity - $O(n \log n)$
4. **Quick Sort** - Highly efficient *Divide and Conquer* algorithm.
5. **Merge Sort** - A stable sorting algorithm with guaranteed $O(n \log n)$ performance.
6. **C# Native Sort** - The highly optimized built-in `.NET` algorithm (IntroSort).

## Architecture & Tech Stack

* **Language:** C#
* **Framework:** .NET (Windows Forms)
* **IDE:** Visual Studio 2026
* **Design Pattern:** The application is highly extensible. All algorithms implement a common `ISortingAlgorithm` interface. This adheres to the **Open/Closed Principle (SOLID)**, allowing new sorting algorithms to be added without modifying the core UI logic.

## Application Demo
<img width="1043" height="637" alt="image" src="https://github.com/user-attachments/assets/d6ee382b-c2b8-4c8d-b99d-99b0ce4b231f" />


## How to Run Locally

1. Ensure you have **Visual Studio 2022/2026** installed with the *.NET Desktop Development* workload.
2. Clone this repository.
