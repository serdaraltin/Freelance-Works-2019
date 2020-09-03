
SHELL := /bin/sh
MAKE  := make
ROOT  := ./compiler

# Directories
INCLUDES := ./khudi
BIN_DIR  := ./bin

CC      := javac
RM      := rm
JAR     := jar
JFLAGS  := cmfv
CFLAGS  := -Xlint
LDFLAGS :=
LIBS    :=
.SUFFIXES: .java .class
MANIFEST_FILE := manifest.txt

echo_cmd = @echo   "  $(1)$(ECHO_FILE_NAME)" ; $(2)

MAKE := $(MAKE) --no-print-directory --silent
CC   := $(call echo_cmd,CC      ,$(CC))
LD   := $(call echo_cmd,LD      ,$(LD))
RM   := $(call echo_cmd,RM      ,$(RM))

usage:
	@echo ""
	@echo "Master Makefile for SUIS."
	@echo ""
	@echo "Usage:"
	@echo "	make all        
	@echo "	make clean      
	@echo "	make clean_all  
	@echo ""

LEXICAL_DIR = $(ROOT)/Lexical
SEMANTIC_DIR = $(ROOT)/Semantic
MAIN_DIR      = $(ROOT)

SRCS =	$(MAIN_DIR)/main.java \
		 $(LEXICAL_DIR)/lexical.java \
         $(SEMANTIC_DIR)/semantic.java \
		 $(SEMANTIC_DIR)/variables.java 
all: $(SRCS) compiler.jar

OBJS = $(SRCS:.java=.class)

compiler.jar:  $(OBJS)
	$(JAR) $(JFLAGS) $(MANIFEST_FILE) compiler.jar $(OBJS)

.java.class:
	$(CC) $(CFLAGS) $<

clean:
	$(RM) $(OBJS)

clean_all:
	$(RM) $(OBJS) compiler.jar
