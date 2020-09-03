#Joseph Mulray A1 Makefile

#variable declaration
JAVA = java
JAR = jar
JC = javac
FLAGS = cp
VIEWER = more
DOCS = javadoc


FILES = Alphabetizer.java \
	CircularShift.java \
	ConsoleOutput.java \
	ConsoleInput.java \
	FileInput.java \
	FileOutput.java \
	Input.java \
	Output.java \
	LineStorage.java \
	MasterControl.java 

MAIN = MasterControl

.PHONY: run view clean

#run and execute program
run:
	@$(JC) $(FILES)
	$(JAVA) $(MAIN)


#view source code
view:
	$(VIEWER) README $(FILES)

clean:
	@rm *.class
	@echo Done.