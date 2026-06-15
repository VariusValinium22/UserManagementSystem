/* GOAL: fetch API, useState, useEffect
    NOTE: useEffect runs once when the page loads(on mount) = auto-fetch + setUsers updates the state; 
            JSX = will display the data on the screen.        
      
    Layer 1: Prove the file works/exports first. Create an EMPTY hook that returns fake values.
        export function useUsers() {
        return { users: [], loading: true, error: null };
        }    
    Layer 2: useState(3): users, loading, error
    Layer 3: Fetch in useEffect. Run once on mount URL: https://apiusermanagement.martinyoungproject.com/api/users
             Flow:  fetch(URL) → .json() on the response → setUsers(data) → setLoading(false)
                    on failure: setError(...), setLoading(false)
    Layer 4: Return Object: return { users, loading, error }
*/

import { useState, useEffect } from "react";

export function useUsers() {
  const [users, setUsers] = useState([]); // array destructing
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch("https://apiusermanagement.martinyoungproject.com/api/users")
      .then((response) => response.json())
      .then((data) => {
        setUsers(data);
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message);
        setLoading(false);
      });
  }, []);

  return { users, loading, error };
}
