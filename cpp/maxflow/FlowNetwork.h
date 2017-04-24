//
// Created by Dmitry Sergeev on 4/23/17.
//

#ifndef AVAILABLE_FLOWNETWORK_H
#define AVAILABLE_FLOWNETWORK_H

#include <vector>
#include <map>
#include <memory>
#include "FlowEdge.h"

class FlowNetwork {
public:
    FlowNetwork() {}
    void add_edge(int from, int to, double capacity) {
        add_vertex(from);
        add_vertex(to);
        add_edge(std::make_shared<FlowEdge>(from, to, capacity));
    }
    const auto edges_at(int vertex) const {
        std::vector<FlowEdge*> result;
        for(const auto & edge : adj.at(vertex))
            result.push_back(edge.get());
        return result;
    }
    const auto size() const { return adj.size(); }
private:
    void add_vertex(int vertex){
        if (adj.find(vertex) == adj.end())
            adj[vertex] = std::vector<std::shared_ptr<FlowEdge>>();
    }
    void add_edge(std::shared_ptr<FlowEdge> edge){
        adj[edge->from()].push_back(edge);
        adj[edge->to()].push_back(edge);
    }
private:
    std::map<int, std::vector<std::shared_ptr<FlowEdge>>> adj;
};


#endif //AVAILABLE_FLOWNETWORK_H
