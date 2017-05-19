﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode._24_ChainOfResponsibility {
    /// <summary>
    /// 总监
    /// </summary>
    class Majordomo : Manager {
        public Majordomo(string name) : base(name) {
        }

        public override void HandleRequest(Request request) {
            if (request.RequestType == Request.Type.Leave && request.Number <= 7) {
                Console.WriteLine(string.Format("{0}批准了{1}{2}天的请求", name, request.Content, request.Number));
            } else if (superior != null) {
                superior.HandleRequest(request);
            }
        }
    }
}
