# This makefile doesnt allow make to track changes in header files!
COMPILER := g++
SRC_DIR := src
BIN_DIR := bin
TARGET := $(BIN_DIR)/program.exe


# Function to recursively find all directories under a given directory
rwildcard=$(foreach d,$(wildcard $1*),$(call rwildcard,$d/,$2) $(filter $(subst *,%,$2),$d))
SOURCES := $(call rwildcard,$(SRC_DIR)/,*.cpp)
OBJECTS = $(subst .cpp,.o,$(addprefix $(BIN_DIR)/, $(SOURCES)))

all: $(TARGET)

$(TARGET): $(OBJECTS)
	$(COMPILER) $^ -o $@

$(BIN_DIR)/%.o:%.cpp
	if not exist "$(@D)" mkdir "$(@D)"
	$(COMPILER) -c $< -o $@

clean:
	rmdir /s /q $(BIN_DIR)

.PHONY: clean
