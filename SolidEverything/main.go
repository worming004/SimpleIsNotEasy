package main

import (
	"bufio"
	"fmt"
	"io"
	"os"
)

func main() {
	stdWriter := newInsuranceWriter(os.Stdout)
	outFile, err := os.Create("./out.csv")
	if err != nil {
		panic(err)
	}
	defer outFile.Close()
	fileWriter := newInsuranceWriter(outFile)
	multiOutFile, err := os.Create("./out-multi.csv")
	if err != nil {
		panic(err)
	}
	defer multiOutFile.Close()
	multiWriter := newInsuranceWriter(io.MultiWriter(os.Stdout, multiOutFile))

	ins := insurance{
		Firstname:     "Mathieu",
		Lastname:      "Scolas",
		InsuranceType: illness,
	}

	scanner := bufio.NewScanner(os.Stdin)
	stdWriter.Write(ins)
	fmt.Println("check console")
	scanner.Scan()
	fileWriter.Write(ins)
	fmt.Println("check out.csv")
	scanner.Scan()
	multiWriter.Write(ins)
	fmt.Println("check out-multi.csv & console")
}

type insuranceType int

const (
	illness insuranceType = iota
	fire
)

type insurance struct {
	Firstname, Lastname string
	InsuranceType       insuranceType
}

type insuranceWriter struct {
	writer io.Writer
}

func newInsuranceWriter(w io.Writer) insuranceWriter {
	return insuranceWriter{
		writer: w,
	}
}

func (w insuranceWriter) Write(i insurance) {
	msg := fmt.Sprintf("%s;%s;%d;\n", i.Firstname, i.Lastname, i.InsuranceType)
	w.writer.Write([]byte(msg))
}
