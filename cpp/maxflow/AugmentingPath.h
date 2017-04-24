//
// Created by Dmitry Sergeev on 4/23/17.
//

#ifndef AVAILABLE_AUGMENTINGPATH_H
#define AVAILABLE_AUGMENTINGPATH_H

#include <map>
#include "FlowEdge.h"

class AugmentingPath {
public:
    void add_edge_to(int vertex, FlowEdge* edge){
        edge_to[vertex] = edge;
    }
    bool has(int vertex) const { return edge_to.find(vertex) != edge_to.end(); }
    bool does_not_have(int vertex) const { return !has(vertex); }
    FlowEdge* to(int vertex){
        return edge_to[vertex];
    }
private:
    std::map<int, FlowEdge*> edge_to;
};


#endif //AVAILABLE_AUGMENTINGPATH_H
