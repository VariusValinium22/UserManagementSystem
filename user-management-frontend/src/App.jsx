import './App.css'
import { useUsers } from './hooks/useUsers'

// temporarily: console.log(users) or show loading/error as text
function App() {
  const { users, loading, error } = useUsers();
  console.log({users, loading, error}); // ← the test
  return (
    <>
      <h1>User Management</h1>
      <p>…placeholder until UserList (C9)…</p>
    </>
  )
}

export default App
