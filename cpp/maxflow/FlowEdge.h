//
// Created by Dmitry Sergeev on 4/23/17.
//

#ifndef AVAILABLE_FLOWEDGE_H
#define AVAILABLE_FLOWEDGE_H


class FlowEdge {
public:
    FlowEdge(int from, int to, double capacity): v(from), w(to), capacity(capacity), flow(0) {}
    int from() const { return v; }
    int to() const { return w; }
    int other(int vertex) const { return is_forward(vertex) ? w : v; }
    double residual_capacity_to(int vertex) const { return is_forward(vertex) ? flow : capacity - flow; }
    void add_residual_flow_to(int vertex, double delta) { flow += is_forward(vertex) ? -delta : delta; }
private:
    bool is_forward(int vertex) const { return vertex == v; }
    int v;
    int w;
    double capacity;
    double flow;
};


#endif //AVAILABLE_FLOWEDGE_H
