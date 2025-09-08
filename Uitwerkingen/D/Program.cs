using D.Database;

/// In dit project gaat het om het Dependency inversion principle
/// 
/// OPDRACHT: 
/// 
/// Herschrijf de code zo dat je voldoet aan dit principe. 
/// 

// Normaal zou je deze instanties maken via dependency injection.
var fakeSqlDb = new FakeSqlDbImplementation();
var userRepository = new UserRepository(fakeSqlDb); 
var userService = new UserService(userRepository);

userService.RegisterUser("Janneke");