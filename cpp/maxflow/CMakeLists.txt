cmake_minimum_required(VERSION 3.7)
project(maxflow)

set(CMAKE_CXX_STANDARD 14)

set(SOURCE_FILES main.cpp FlowEdge.cpp FlowEdge.h FlowNetwork.cpp FlowNetwork.h FordFulkerson.cpp FordFulkerson.h AugmentingPath.cpp AugmentingPath.h)
add_executable(available ${SOURCE_FILES})