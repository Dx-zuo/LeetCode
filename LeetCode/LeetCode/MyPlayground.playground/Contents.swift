//: Playground - noun: a place where people can play

import UIKit
////链表排序

class Node {
    var value : Int = 0
    var next : Node?
}

func sort(node:Node) -> Node {
    var L = node
    var p : Node!
    var p1 :Node!
    
    if node.next == nil {return L}
    
    while L.next != nil {
        p = L.next!
        while p1.next != nil {
            p1 = L.next
            if p?.value > p1?.value {
                var temp = p.value
                p.value = (p1?.value)!
                p1?.value = temp
            }
        }
        L = L.next!
    }
    return L
}
