package main

func main() {}

// Manipulated is a string that will be manipulated
type Manipulated string

// ReadTransformWrite do all actions
func (manipulated Manipulated) ReadTransformWrite() {
	manipulated.read()
	manipulated.transform()
	manipulated.write()
}

func (manipulated Manipulated) read() {
	//
}
func (manipulated Manipulated) transform() {
	//
}
func (manipulated Manipulated) write() {
	//
}
