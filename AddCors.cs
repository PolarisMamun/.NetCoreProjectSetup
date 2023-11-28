          //add cross origin rules in PIPC project
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader()
                        .AllowAnyMethod()
                        .WithExposedHeaders("WWW-Authenticate")
                        .WithOrigins(Configuration.GetSection("CorsOrigins").Get<string[]>())
                        .AllowCredentials();
                });
            });


//1. First need to above the app(var app = builder.Build();)
//add cross-origin rules in my dev project
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll",
        b => b.AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod());
});

//2. Second, after made the policy we need to tell the pipeline to use the policy(main call after app.UseHttpsRedirection();)


app.UseCors("AllowAll");


Cross-Origin Resource Sharing (CORS) is a security feature implemented by web browsers to restrict web pages from making requests to a different domain than the one that served the web page. 
This security measure is in place to prevent unauthorized access to resources on a different domain. 
When you're working with a .NET Core project and want to make requests to it from a web application hosted on a different domain, you might encounter CORS issues.

Here's why you might need to add CORS support to your .NET Core project:
Same-Origin Policy: Browsers, by default, enforce the Same-Origin Policy, which restricts web pages from making requests to a different domain than the one that served the web page. 
This policy prevents potential security vulnerabilities, such as cross-site request forgery (CSRF) and unauthorized data access.
APIs and Client-Side Applications: If your .NET Core project is serving an API and you want to allow client-side applications (e.g., a single-page application) hosted 
on a different domain to make requests to your API, you need to configure CORS.
Cross-Domain Requests: CORS is needed when you make requests from a web application on one domain (e.g., https://client-application.com) 
to an API hosted on a different domain (e.g., https://api-server.com). Without CORS, the browser would block such requests.
