-- Create Product table
CREATE TABLE IF NOT EXISTS products (
    sku TEXT PRIMARY KEY,
    name TEXT NOT NULL,
    price REAL NOT NULL
);

-- Create Stock table
CREATE TABLE IF NOT EXISTS stocks (
    sku TEXT PRIMARY KEY,
    quantity INTEGER NOT NULL,
    FOREIGN KEY (sku) REFERENCES products(sku)
);
