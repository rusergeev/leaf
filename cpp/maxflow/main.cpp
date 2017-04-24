#include <iostream>

#include "FlowNetwork.h"
#include "FordFulkerson.h"

int main() {


    FlowNetwork net;

    net.add_edge(1, 2, 10);
    net.add_edge(1, 3, 13);

    net.add_edge(2, 4, 11);
    net.add_edge(2, 5, 2);

    net.add_edge(3, 2, 6);
    net.add_edge(3, 6, 8);

    net.add_edge(4, 7, 4);

    net.add_edge(5, 3, 4);
    net.add_edge(5, 8, 13);

    net.add_edge(6, 5, 5);
    net.add_edge(6, 8, 15);

    net.add_edge(7, 8, 8);

    auto ans = FordFulkerson::max_flow(net, 1, 8);

    std::cout << "max flow: " << ans << std::endl;

    return 0;
}