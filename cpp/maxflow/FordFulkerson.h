//
// Created by Dmitry Sergeev on 4/23/17.
//

#ifndef AVAILABLE_FORDFULKERSON_H
#define AVAILABLE_FORDFULKERSON_H

#include <vector>
#include <limits>
#include <queue>
#include <set>
#include "FlowEdge.h"
#include "FlowNetwork.h"
#include "AugmentingPath.h"

class FordFulkerson {
public:
    static double max_flow(FlowNetwork graph, int source, int target) {
        double value = 0.0;
        AugmentingPath path;
        while ((path = augmenting_path(graph, source, target)).has(target)){
            double bottleneck = std::numeric_limits<double>::infinity();

            for (int vertex = target; vertex != source; vertex = path.to(vertex)->other(vertex))
                bottleneck = std::min(bottleneck, path.to(vertex)->residual_capacity_to(vertex));

            for (int vertex = target; vertex != source; vertex = path.to(vertex)->other(vertex))
                path.to(vertex)->add_residual_flow_to(vertex, bottleneck);

            value += bottleneck;
        }
        return value;
    }

private:
    static AugmentingPath augmenting_path(FlowNetwork graph, int source, int target){
        AugmentingPath path;

        std::queue<int> queue;
        path.add_edge_to(source, nullptr);
        queue.push(source);

        while (!queue.empty()) {
            int vertex = queue.front();
            queue.pop();
            for (const auto & edge : graph.edges_at(vertex)) {
                int next_vertex = edge->other(vertex);
                if (edge->residual_capacity_to(next_vertex) > 0 && path.does_not_have(next_vertex)) {
                    path.add_edge_to(next_vertex, edge);
                    queue.push(next_vertex);
                }
            }
        }
        return path;
    }
};


#endif //AVAILABLE_FORDFULKERSON_H
