/* Write the component. Take users, loading, and error and turn them into UI.
Objective: turn users into visible UI on the page
	remove the console.log smoke test from App.jsx
 */
export default function UserList({ users, loading, error }) {
  // console.log({users, loading, error});
  // return <p>UserList placeholder</p>
  if (loading) return <p>Loading...</p>;
  if (error) return <p>Error: {error}</p>;
  if (users.length === 0) return <p>No users found.</p>;

  return (
    <ul className="user-list">
      {users.map((user) => (
        <li key={user.id}>{user.name}</li>
      ))}
    </ul>
  );
}
