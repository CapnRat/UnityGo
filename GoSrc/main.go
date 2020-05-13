package main

import "C"

//export Add
func Add(x, y int) int {
	return x + y
}

//export GetInt
func GetInt() int {
	return 42
}

//export GetString
func GetString() string {
	return "A string from Go!"
}

func main() {
	// needed but not used
}