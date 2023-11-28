          //add cross origin rules
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
