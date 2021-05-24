using System;
using ExpressSharp;

namespace Expr
{
	class Program
	{
		static void Main(string[] args)
		{
			Express server = new Express();

			server.GET("/", (req, res) => res.Status(200));

			server.GET("/user/{id}", (req, res) =>
			{
				res.Send(req._request.Url.Segments[1].Substring(1));
			});

			server.POST("/", (req, res) => res.Status(200));

			server.Listen(80);
		}
	}
}
