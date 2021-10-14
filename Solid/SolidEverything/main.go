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
	Firstname     string
	Lastname      string
	InsuranceType insuranceType
}

func newInsuranceWriter(w io.Writer) insuranceCsvWriter {
	return insuranceCsvWriter{
		writer: w,
	}
}

type insuranceCsvWriter struct {
	writer io.Writer
}

func (w insuranceCsvWriter) Write(i insurance) {
	msg := fmt.Sprintf("%s;%s;%d;\n", i.Firstname, i.Lastname, i.InsuranceType)
	w.writer.Write([]byte(msg))
}
