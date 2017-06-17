
CSC=csc
CSC=mcs
# dll needed for mono, target needed to avoid opening a console
CSFLAGS=/r:System.Windows.Forms.dll /target:winexe

MAIN=SwitchAndPasteToMatlab
PROG=$(MAIN).exe
SRC=$(MAIN).cs



all: $(PROG) test

$(PROG): $(SRC)
	$(CSC) $(CSFLAGS) $(SRC)


test:
	$(PROG)
