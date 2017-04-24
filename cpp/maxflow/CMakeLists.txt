cmake_minimum_required(VERSION 3.7)
project(maxflow)

set(CMAKE_CXX_STANDARD 14)

set(SOURCE_FILES main.cpp FlowEdge.h FlowNetwork.h FordFulkerson.h AugmentingPath.h)
add_executable(maxflow ${SOURCE_FILES})